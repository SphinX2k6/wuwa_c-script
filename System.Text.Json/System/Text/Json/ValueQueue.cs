using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace System.Text.Json
{
	// Token: 0x0200003F RID: 63
	[StructLayout(LayoutKind.Auto)]
	internal struct ValueQueue<T>
	{
		// Token: 0x060004A2 RID: 1186 RVA: 0x00014AEC File Offset: 0x00012CEC
		public void Enqueue(T value)
		{
			byte state = this._state;
			if (state != 0)
			{
				if (state == 1)
				{
					Queue<T> queue;
					if ((queue = this._multiple) == null)
					{
						queue = (this._multiple = new Queue<T>());
					}
					queue.Enqueue(this._single);
					this._single = default(T);
					this._state = 2;
				}
				this._multiple.Enqueue(value);
				return;
			}
			this._single = value;
			this._state = 1;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00014B5C File Offset: 0x00012D5C
		public bool TryDequeue([MaybeNullWhen(false)] out T value)
		{
			byte state = this._state;
			if (state == 0)
			{
				value = default(T);
				return false;
			}
			if (state != 1)
			{
				return this._multiple.TryDequeue(out value);
			}
			value = this._single;
			this._single = default(T);
			this._state = 0;
			return true;
		}

		// Token: 0x040000EE RID: 238
		private byte _state;

		// Token: 0x040000EF RID: 239
		private T _single;

		// Token: 0x040000F0 RID: 240
		private Queue<T> _multiple;
	}
}
