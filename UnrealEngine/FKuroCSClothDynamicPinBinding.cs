using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A6 RID: 6054
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSClothDynamicPinBinding")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroCSClothDynamicPinBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015E04 RID: 89604 RVA: 0x00201B7A File Offset: 0x001FFD7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSClothDynamicPinBinding._ScriptStructPtr != 0) ? FKuroCSClothDynamicPinBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSClothDynamicPinBinding", ref FKuroCSClothDynamicPinBinding._ScriptStructPtr);
		}

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x06015E05 RID: 89605 RVA: 0x00201B9E File Offset: 0x001FFD9E
		// (set) Token: 0x06015E06 RID: 89606 RVA: 0x00201BB2 File Offset: 0x001FFDB2
		public unsafe AActor MeshActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSClothDynamicPinBinding.__PropertyOffset_MeshActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSClothDynamicPinBinding.__PropertyOffset_MeshActor, value);
			}
		}

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x06015E07 RID: 89607 RVA: 0x00201BC7 File Offset: 0x001FFDC7
		// (set) Token: 0x06015E08 RID: 89608 RVA: 0x00201BDB File Offset: 0x001FFDDB
		public unsafe AActor PinProviderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderActor, value);
			}
		}

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x06015E09 RID: 89609 RVA: 0x00201BF0 File Offset: 0x001FFDF0
		// (set) Token: 0x06015E0A RID: 89610 RVA: 0x00201C04 File Offset: 0x001FFE04
		public unsafe FName PinProviderFunctionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderFunctionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderFunctionName) = value;
			}
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x06015E0B RID: 89611 RVA: 0x00201C19 File Offset: 0x001FFE19
		// (set) Token: 0x06015E0C RID: 89612 RVA: 0x00201C29 File Offset: 0x001FFE29
		public unsafe int PinProviderIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSClothDynamicPinBinding.__PropertyOffset_PinProviderIndex) = value;
			}
		}

		// Token: 0x06015E0D RID: 89613 RVA: 0x00201C3A File Offset: 0x001FFE3A
		public FKuroCSClothDynamicPinBinding()
		{
		}

		// Token: 0x06015E0E RID: 89614 RVA: 0x00201C42 File Offset: 0x001FFE42
		[NullableContext(1)]
		public FKuroCSClothDynamicPinBinding(AActor MeshActor, AActor PinProviderActor, FName PinProviderFunctionName, int PinProviderIndex)
		{
			this.MeshActor = MeshActor;
			this.PinProviderActor = PinProviderActor;
			this.PinProviderFunctionName = PinProviderFunctionName;
			this.PinProviderIndex = PinProviderIndex;
		}

		// Token: 0x06015E0F RID: 89615 RVA: 0x00201C67 File Offset: 0x001FFE67
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSClothDynamicPinBinding.StaticStruct();
		}

		// Token: 0x06015E10 RID: 89616 RVA: 0x00201C73 File Offset: 0x001FFE73
		public FKuroCSClothDynamicPinBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015E11 RID: 89617 RVA: 0x00201C7D File Offset: 0x001FFE7D
		public FKuroCSClothDynamicPinBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015E12 RID: 89618 RVA: 0x00201C88 File Offset: 0x001FFE88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSClothDynamicPinBinding(Pointer, false, true);
		}

		// Token: 0x06015E13 RID: 89619 RVA: 0x00201C92 File Offset: 0x001FFE92
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSClothDynamicPinBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0400BEDA RID: 48858
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSClothDynamicPinBinding";

		// Token: 0x0400BEDB RID: 48859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BEDC RID: 48860
		internal static int __PropertyOffset_MeshActor;

		// Token: 0x0400BEDD RID: 48861
		internal static int __PropertyOffset_PinProviderActor;

		// Token: 0x0400BEDE RID: 48862
		internal static int __PropertyOffset_PinProviderFunctionName;

		// Token: 0x0400BEDF RID: 48863
		internal static int __PropertyOffset_PinProviderIndex;
	}
}
