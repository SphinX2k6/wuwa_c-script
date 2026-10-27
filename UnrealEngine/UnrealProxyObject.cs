using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200009D RID: 157
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class UnrealProxyObject : UnrealObject, IDisposable
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00018A94 File Offset: 0x00016C94
		public UnrealObject MemoryOwner
		{
			get
			{
				return this._MemoryOwner;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00018A9C File Offset: 0x00016C9C
		public bool IsNativePtrAllocated
		{
			get
			{
				return this._MemoryOwner == null;
			}
		}

		// Token: 0x0600107E RID: 4222
		protected abstract IntPtr AllocNativePtr();

		// Token: 0x0600107F RID: 4223
		protected abstract void DeallocNativePtr();

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001080 RID: 4224
		public abstract bool AllowMoveAssign { get; }

		// Token: 0x06001081 RID: 4225 RVA: 0x00018AA7 File Offset: 0x00016CA7
		public virtual void MoveAssign(IntPtr FromNativePtr)
		{
			throw new UnreachableException();
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001082 RID: 4226
		public abstract bool AllowCopyAssign { get; }

		// Token: 0x06001083 RID: 4227 RVA: 0x00018AAE File Offset: 0x00016CAE
		public virtual void CopyAssign(IntPtr FromNativePtr)
		{
			throw new UnreachableException();
		}

		// Token: 0x06001084 RID: 4228
		public abstract void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr));

		// Token: 0x06001085 RID: 4229 RVA: 0x00018AB5 File Offset: 0x00016CB5
		protected UnrealProxyObject()
		{
			this._NativePtr = this.AllocNativePtr();
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00018ACC File Offset: 0x00016CCC
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

		// Token: 0x06001087 RID: 4231 RVA: 0x00018B20 File Offset: 0x00016D20
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

		// Token: 0x06001088 RID: 4232 RVA: 0x00018B73 File Offset: 0x00016D73
		protected UnrealProxyObject(UnrealProxyObject.ENoInit Ctor)
		{
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00018B7B File Offset: 0x00016D7B
		public void Dispose()
		{
			this.OnScriptObjectDestruct();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00018B8C File Offset: 0x00016D8C
		~UnrealProxyObject()
		{
			this.OnScriptObjectDestruct();
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00018BB8 File Offset: 0x00016DB8
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

		// Token: 0x0600108C RID: 4236 RVA: 0x00018C48 File Offset: 0x00016E48
		public override bool IsValid()
		{
			if (this._MemoryOwner != null)
			{
				return this._NativePtr != 0 && this._MemoryOwner.IsValid();
			}
			return this._NativePtr > (IntPtr)0;
		}

		// Token: 0x04000204 RID: 516
		internal UnrealObject _MemoryOwner;

		// Token: 0x02002B27 RID: 11047
		[NullableContext(0)]
		protected enum ENoInit
		{
			// Token: 0x04016380 RID: 91008
			NoInit
		}
	}
}
