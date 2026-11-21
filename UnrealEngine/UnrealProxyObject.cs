using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000082 RID: 130
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class UnrealProxyObject : UnrealObject, IDisposable
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000137B8 File Offset: 0x000119B8
		public UnrealObject MemoryOwner
		{
			get
			{
				return this._MemoryOwner;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000137C0 File Offset: 0x000119C0
		public bool IsNativePtrAllocated
		{
			get
			{
				return this._MemoryOwner == null;
			}
		}

		// Token: 0x06000C11 RID: 3089
		protected abstract IntPtr AllocNativePtr();

		// Token: 0x06000C12 RID: 3090
		protected abstract void DeallocNativePtr();

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000C13 RID: 3091
		public abstract bool AllowMoveAssign { get; }

		// Token: 0x06000C14 RID: 3092 RVA: 0x000137CB File Offset: 0x000119CB
		public virtual void MoveAssign(IntPtr FromNativePtr)
		{
			throw new UnreachableException();
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000C15 RID: 3093
		public abstract bool AllowCopyAssign { get; }

		// Token: 0x06000C16 RID: 3094 RVA: 0x000137D2 File Offset: 0x000119D2
		public virtual void CopyAssign(IntPtr FromNativePtr)
		{
			throw new UnreachableException();
		}

		// Token: 0x06000C17 RID: 3095
		public abstract void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr));

		// Token: 0x06000C18 RID: 3096 RVA: 0x000137D9 File Offset: 0x000119D9
		protected UnrealProxyObject()
		{
			this._NativePtr = this.AllocNativePtr();
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000137F0 File Offset: 0x000119F0
		protected UnrealProxyObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr)
		{
			SharpherealAssert.Assert(NativePtr != IntPtr.Zero);
			bool condition;
			if (MemoryOwner != null && !(MemoryOwner is UnrealUObject))
			{
				UnrealProxyObject unrealProxyObject = MemoryOwner as UnrealProxyObject;
				if (unrealProxyObject == null || !unrealProxyObject.IsNativePtrAllocated)
				{
					condition = false;
					goto IL_3A;
				}
			}
			condition = true;
			IL_3A:
			SharpherealAssert.Assert(condition);
			this._MemoryOwner = MemoryOwner;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00013844 File Offset: 0x00011A44
		protected UnrealProxyObject(IntPtr OtherNativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : this()
		{
			SharpherealAssert.Assert(OtherNativePtr != IntPtr.Zero);
			if (bWithMoveAssign && this.AllowMoveAssign)
			{
				this.MoveAssign(OtherNativePtr);
				return;
			}
			if (bWithCopyAssignIfCannotMove && this.AllowCopyAssign)
			{
				this.CopyAssign(OtherNativePtr);
				return;
			}
			throw new UnreachableException("At least one of move construction and copy construction needs to be implemented");
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00013897 File Offset: 0x00011A97
		protected UnrealProxyObject(UnrealProxyObject.ENoInit Ctor)
		{
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0001389F File Offset: 0x00011A9F
		public void Dispose()
		{
			this.OnScriptObjectDestruct();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000138B0 File Offset: 0x00011AB0
		~UnrealProxyObject()
		{
			this.OnScriptObjectDestruct();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000138DC File Offset: 0x00011ADC
		protected virtual void OnScriptObjectDestruct()
		{
			if (this._NativePtr != IntPtr.Zero && this.IsNativePtrAllocated)
			{
				try
				{
					this.DeallocNativePtr();
				}
				catch (Exception ex)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Fail to dispose ");
					defaultInterpolatedStringHandler.AppendFormatted<Type>(base.GetType());
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
					UnrealLogger.ErrorNoTrace(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				this._NativePtr = IntPtr.Zero;
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0001396C File Offset: 0x00011B6C
		public override bool IsValid()
		{
			if (this._MemoryOwner != null)
			{
				return this._NativePtr != 0 && this._MemoryOwner.IsValid();
			}
			return this._NativePtr > (IntPtr)0;
		}

		// Token: 0x040001BD RID: 445
		internal UnrealObject _MemoryOwner;

		// Token: 0x020008D5 RID: 2261
		[NullableContext(0)]
		protected enum ENoInit
		{
			// Token: 0x04005796 RID: 22422
			NoInit
		}
	}
}
