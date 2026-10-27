using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001147 RID: 4423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeMixer")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeMixer : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601029C RID: 66204 RVA: 0x0017D112 File Offset: 0x0017B312
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeMixer._ClassPtr;
		}

		// Token: 0x0601029D RID: 66205 RVA: 0x0017D120 File Offset: 0x0017B320
		public USoundNodeMixer() : this(BuiltinUtils.AllocNativeUObject(USoundNodeMixer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601029E RID: 66206 RVA: 0x0017D148 File Offset: 0x0017B348
		public USoundNodeMixer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeMixer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x0601029F RID: 66207 RVA: 0x0017D17C File Offset: 0x0017B37C
		// (set) Token: 0x060102A0 RID: 66208 RVA: 0x0017D1B5 File Offset: 0x0017B3B5
		public TArray<float> InputVolume
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._InputVolume) == null)
				{
					result = (this._InputVolume = new TArray<float>(base.NativePtr + (IntPtr)USoundNodeMixer.__PropertyOffset_InputVolume, this));
				}
				return result;
			}
			set
			{
				this.InputVolume.CopyAssign(value);
			}
		}

		// Token: 0x060102A1 RID: 66209 RVA: 0x0017D1C3 File Offset: 0x0017B3C3
		static USoundNodeMixer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeMixer");
		}

		// Token: 0x060102A2 RID: 66210 RVA: 0x0017D1D1 File Offset: 0x0017B3D1
		protected USoundNodeMixer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B21 RID: 35617
		public new const string __ObjectPath = "/Script/Engine.SoundNodeMixer";

		// Token: 0x04008B22 RID: 35618
		private static IntPtr _ClassPtr;

		// Token: 0x04008B23 RID: 35619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B24 RID: 35620
		internal static int __PropertyOffset_InputVolume;

		// Token: 0x04008B25 RID: 35621
		[Nullable(2)]
		private TArray<float> _InputVolume;
	}
}
