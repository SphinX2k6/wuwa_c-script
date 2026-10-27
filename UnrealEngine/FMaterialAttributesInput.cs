using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D78 RID: 3448
	[UnrealObjectPath("/Script/Engine.MaterialAttributesInput")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMaterialAttributesInput : FExpressionInput, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BC6E RID: 48238 RVA: 0x0010D0FD File Offset: 0x0010B2FD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialAttributesInput._ScriptStructPtr != 0) ? FMaterialAttributesInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialAttributesInput", ref FMaterialAttributesInput._ScriptStructPtr);
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x0010D121 File Offset: 0x0010B321
		// (set) Token: 0x0600BC70 RID: 48240 RVA: 0x0010D131 File Offset: 0x0010B331
		public unsafe long PropertyConnectedBitmask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialAttributesInput.__PropertyOffset_PropertyConnectedBitmask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialAttributesInput.__PropertyOffset_PropertyConnectedBitmask) = value;
			}
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x0010D142 File Offset: 0x0010B342
		public FMaterialAttributesInput()
		{
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x0010D14A File Offset: 0x0010B34A
		[NullableContext(1)]
		public FMaterialAttributesInput(long PropertyConnectedBitmask, UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			this.PropertyConnectedBitmask = PropertyConnectedBitmask;
			base.OutputIndex = OutputIndex;
			base.ExpressionName = ExpressionName;
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x0010D168 File Offset: 0x0010B368
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialAttributesInput.StaticStruct();
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x0010D174 File Offset: 0x0010B374
		[NullableContext(2)]
		public FMaterialAttributesInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x0010D17E File Offset: 0x0010B37E
		public FMaterialAttributesInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x0010D189 File Offset: 0x0010B389
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialAttributesInput(Pointer, false, true);
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x0010D193 File Offset: 0x0010B393
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialAttributesInput(Pointer, MemoryOwner);
		}

		// Token: 0x0400634D RID: 25421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialAttributesInput";

		// Token: 0x0400634E RID: 25422
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400634F RID: 25423
		internal static int __PropertyOffset_PropertyConnectedBitmask;
	}
}
