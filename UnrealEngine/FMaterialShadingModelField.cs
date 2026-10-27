using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E97 RID: 3735
	[UnrealObjectPath("/Script/Engine.MaterialShadingModelField")]
	[UnrealStructLayout(2, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FMaterialShadingModelField : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C926 RID: 51494 RVA: 0x00124DB7 File Offset: 0x00122FB7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialShadingModelField._ScriptStructPtr != 0) ? FMaterialShadingModelField._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialShadingModelField", ref FMaterialShadingModelField._ScriptStructPtr);
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600C927 RID: 51495 RVA: 0x00124DDB File Offset: 0x00122FDB
		// (set) Token: 0x0600C928 RID: 51496 RVA: 0x00124DEB File Offset: 0x00122FEB
		public unsafe ushort ShadingModelField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialShadingModelField.__PropertyOffset_ShadingModelField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialShadingModelField.__PropertyOffset_ShadingModelField) = (short)value;
			}
		}

		// Token: 0x0600C929 RID: 51497 RVA: 0x00124DFC File Offset: 0x00122FFC
		public FMaterialShadingModelField()
		{
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x00124E04 File Offset: 0x00123004
		public FMaterialShadingModelField(ushort ShadingModelField)
		{
			this.ShadingModelField = ShadingModelField;
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x00124E13 File Offset: 0x00123013
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialShadingModelField.StaticStruct();
		}

		// Token: 0x0600C92C RID: 51500 RVA: 0x00124E1F File Offset: 0x0012301F
		[NullableContext(2)]
		public FMaterialShadingModelField(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C92D RID: 51501 RVA: 0x00124E29 File Offset: 0x00123029
		public FMaterialShadingModelField(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C92E RID: 51502 RVA: 0x00124E34 File Offset: 0x00123034
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialShadingModelField(Pointer, false, true);
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x00124E3E File Offset: 0x0012303E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialShadingModelField(Pointer, MemoryOwner);
		}

		// Token: 0x04006C3F RID: 27711
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialShadingModelField";

		// Token: 0x04006C40 RID: 27712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006C41 RID: 27713
		internal static int __PropertyOffset_ShadingModelField;
	}
}
