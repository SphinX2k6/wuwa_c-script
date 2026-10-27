using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C7 RID: 711
	[UnrealObjectPath("/Script/AnimationCore.TransformConstraintDescription")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTransformConstraintDescription : FConstraintDescriptionEx, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600276D RID: 10093 RVA: 0x0003B1D9 File Offset: 0x000393D9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformConstraintDescription._ScriptStructPtr != 0) ? FTransformConstraintDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.TransformConstraintDescription", ref FTransformConstraintDescription._ScriptStructPtr);
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x0003B1FD File Offset: 0x000393FD
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x0003B20D File Offset: 0x0003940D
		public unsafe ETransformConstraintType TransformType
		{
			get
			{
				return (ETransformConstraintType)(*(base.NativePtr + (IntPtr)FTransformConstraintDescription.__PropertyOffset_TransformType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformConstraintDescription.__PropertyOffset_TransformType) = (byte)value;
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0003B21E File Offset: 0x0003941E
		public FTransformConstraintDescription()
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0003B226 File Offset: 0x00039426
		[NullableContext(1)]
		public FTransformConstraintDescription(ETransformConstraintType TransformType, FFilterOptionPerAxis AxesFilterOption)
		{
			this.TransformType = TransformType;
			base.AxesFilterOption = AxesFilterOption;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0003B23C File Offset: 0x0003943C
		protected override IntPtr GetUStructPtr()
		{
			return FTransformConstraintDescription.StaticStruct();
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x0003B248 File Offset: 0x00039448
		[NullableContext(2)]
		public FTransformConstraintDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0003B252 File Offset: 0x00039452
		public FTransformConstraintDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0003B25D File Offset: 0x0003945D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformConstraintDescription(Pointer, false, true);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x0003B267 File Offset: 0x00039467
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformConstraintDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04000F8B RID: 3979
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimationCore.TransformConstraintDescription";

		// Token: 0x04000F8C RID: 3980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F8D RID: 3981
		internal static int __PropertyOffset_TransformType;
	}
}
