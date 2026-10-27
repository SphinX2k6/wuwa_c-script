using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002665 RID: 9829
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessCopyBatch")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPropertyAccessCopyBatch : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024859 RID: 149593 RVA: 0x0036122D File Offset: 0x0035F42D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessCopyBatch._ScriptStructPtr != 0) ? FPropertyAccessCopyBatch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessCopyBatch", ref FPropertyAccessCopyBatch._ScriptStructPtr);
		}

		// Token: 0x17008CC3 RID: 36035
		// (get) Token: 0x0602485A RID: 149594 RVA: 0x00361254 File Offset: 0x0035F454
		// (set) Token: 0x0602485B RID: 149595 RVA: 0x00361297 File Offset: 0x0035F497
		public TArray<FPropertyAccessCopy> Copies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyAccessCopy> result;
				if ((result = this._Copies) == null)
				{
					result = (this._Copies = new TArray<FPropertyAccessCopy>(base.NativePtr + (IntPtr)FPropertyAccessCopyBatch.__PropertyOffset_Copies, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Copies.CopyAssign(value);
			}
		}

		// Token: 0x0602485C RID: 149596 RVA: 0x003612A5 File Offset: 0x0035F4A5
		public FPropertyAccessCopyBatch()
		{
		}

		// Token: 0x0602485D RID: 149597 RVA: 0x003612AD File Offset: 0x0035F4AD
		public FPropertyAccessCopyBatch(TArray<FPropertyAccessCopy> Copies)
		{
			this.Copies = Copies;
		}

		// Token: 0x0602485E RID: 149598 RVA: 0x003612BC File Offset: 0x0035F4BC
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessCopyBatch.StaticStruct();
		}

		// Token: 0x0602485F RID: 149599 RVA: 0x003612C8 File Offset: 0x0035F4C8
		[NullableContext(2)]
		public FPropertyAccessCopyBatch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024860 RID: 149600 RVA: 0x003612D2 File Offset: 0x0035F4D2
		public FPropertyAccessCopyBatch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024861 RID: 149601 RVA: 0x003612DD File Offset: 0x0035F4DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessCopyBatch(Pointer, false, true);
		}

		// Token: 0x06024862 RID: 149602 RVA: 0x003612E7 File Offset: 0x0035F4E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessCopyBatch(Pointer, MemoryOwner);
		}

		// Token: 0x040139FC RID: 80380
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessCopyBatch";

		// Token: 0x040139FD RID: 80381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040139FE RID: 80382
		internal static int __PropertyOffset_Copies;

		// Token: 0x040139FF RID: 80383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyAccessCopy> _Copies;
	}
}
