using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001815 RID: 6165
	[UnrealObjectPath("/Script/KuroDynamicMeshBatch.PropMaterialParams")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FPropMaterialParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016CE3 RID: 93411 RVA: 0x002146A6 File Offset: 0x002128A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropMaterialParams._ScriptStructPtr != 0) ? FPropMaterialParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicMeshBatch.PropMaterialParams", ref FPropMaterialParams._ScriptStructPtr);
		}

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x06016CE4 RID: 93412 RVA: 0x002146CA File Offset: 0x002128CA
		// (set) Token: 0x06016CE5 RID: 93413 RVA: 0x002146DE File Offset: 0x002128DE
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropMaterialParams.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropMaterialParams.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17005C18 RID: 23576
		// (get) Token: 0x06016CE6 RID: 93414 RVA: 0x002146F3 File Offset: 0x002128F3
		// (set) Token: 0x06016CE7 RID: 93415 RVA: 0x00214703 File Offset: 0x00212903
		public unsafe float TextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropMaterialParams.__PropertyOffset_TextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropMaterialParams.__PropertyOffset_TextureIndex) = value;
			}
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x00214714 File Offset: 0x00212914
		public FPropMaterialParams()
		{
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x0021471C File Offset: 0x0021291C
		public FPropMaterialParams(FLinearColor Color, float TextureIndex)
		{
			this.Color = Color;
			this.TextureIndex = TextureIndex;
		}

		// Token: 0x06016CEA RID: 93418 RVA: 0x00214732 File Offset: 0x00212932
		protected override IntPtr GetUStructPtr()
		{
			return FPropMaterialParams.StaticStruct();
		}

		// Token: 0x06016CEB RID: 93419 RVA: 0x0021473E File Offset: 0x0021293E
		[NullableContext(2)]
		public FPropMaterialParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016CEC RID: 93420 RVA: 0x00214748 File Offset: 0x00212948
		public FPropMaterialParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016CED RID: 93421 RVA: 0x00214753 File Offset: 0x00212953
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropMaterialParams(Pointer, false, true);
		}

		// Token: 0x06016CEE RID: 93422 RVA: 0x0021475D File Offset: 0x0021295D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropMaterialParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400C5F0 RID: 50672
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicMeshBatch.PropMaterialParams";

		// Token: 0x0400C5F1 RID: 50673
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C5F2 RID: 50674
		internal static int __PropertyOffset_Color;

		// Token: 0x0400C5F3 RID: 50675
		internal static int __PropertyOffset_TextureIndex;
	}
}
