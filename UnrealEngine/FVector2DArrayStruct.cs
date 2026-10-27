using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019CB RID: 6603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMath.Vector2DArrayStruct")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FVector2DArrayStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018893 RID: 100499 RVA: 0x0024226F File Offset: 0x0024046F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2DArrayStruct._ScriptStructPtr != 0) ? FVector2DArrayStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.Vector2DArrayStruct", ref FVector2DArrayStruct._ScriptStructPtr);
		}

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x06018894 RID: 100500 RVA: 0x00242294 File Offset: 0x00240494
		// (set) Token: 0x06018895 RID: 100501 RVA: 0x002422D7 File Offset: 0x002404D7
		public TArray<FVector2D> Vector2Ds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._Vector2Ds) == null)
				{
					result = (this._Vector2Ds = new TArray<FVector2D>(base.NativePtr + (IntPtr)FVector2DArrayStruct.__PropertyOffset_Vector2Ds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vector2Ds.CopyAssign(value);
			}
		}

		// Token: 0x06018896 RID: 100502 RVA: 0x002422E5 File Offset: 0x002404E5
		public FVector2DArrayStruct()
		{
		}

		// Token: 0x06018897 RID: 100503 RVA: 0x002422ED File Offset: 0x002404ED
		public FVector2DArrayStruct(TArray<FVector2D> Vector2Ds)
		{
			this.Vector2Ds = Vector2Ds;
		}

		// Token: 0x06018898 RID: 100504 RVA: 0x002422FC File Offset: 0x002404FC
		protected override IntPtr GetUStructPtr()
		{
			return FVector2DArrayStruct.StaticStruct();
		}

		// Token: 0x06018899 RID: 100505 RVA: 0x00242308 File Offset: 0x00240508
		[NullableContext(2)]
		public FVector2DArrayStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601889A RID: 100506 RVA: 0x00242312 File Offset: 0x00240512
		public FVector2DArrayStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601889B RID: 100507 RVA: 0x0024231D File Offset: 0x0024051D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVector2DArrayStruct(Pointer, false, true);
		}

		// Token: 0x0601889C RID: 100508 RVA: 0x00242327 File Offset: 0x00240527
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVector2DArrayStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400D419 RID: 54297
		public const string __ObjectPath = "/Script/KuroMath.Vector2DArrayStruct";

		// Token: 0x0400D41A RID: 54298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D41B RID: 54299
		internal static int __PropertyOffset_Vector2Ds;

		// Token: 0x0400D41C RID: 54300
		[Nullable(2)]
		private TArray<FVector2D> _Vector2Ds;
	}
}
