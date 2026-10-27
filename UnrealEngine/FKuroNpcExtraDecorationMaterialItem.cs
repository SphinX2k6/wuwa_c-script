using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B80 RID: 7040
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMaterialItem")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroNpcExtraDecorationMaterialItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AB6D RID: 109421 RVA: 0x00275D2A File Offset: 0x00273F2A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNpcExtraDecorationMaterialItem._ScriptStructPtr != 0) ? FKuroNpcExtraDecorationMaterialItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMaterialItem", ref FKuroNpcExtraDecorationMaterialItem._ScriptStructPtr);
		}

		// Token: 0x17006B72 RID: 27506
		// (get) Token: 0x0601AB6E RID: 109422 RVA: 0x00275D4E File Offset: 0x00273F4E
		// (set) Token: 0x0601AB6F RID: 109423 RVA: 0x00275D5E File Offset: 0x00273F5E
		public unsafe int SlotID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMaterialItem.__PropertyOffset_SlotID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMaterialItem.__PropertyOffset_SlotID) = value;
			}
		}

		// Token: 0x17006B73 RID: 27507
		// (get) Token: 0x0601AB70 RID: 109424 RVA: 0x00275D6F File Offset: 0x00273F6F
		// (set) Token: 0x0601AB71 RID: 109425 RVA: 0x00275D83 File Offset: 0x00273F83
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroNpcExtraDecorationMaterialItem.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroNpcExtraDecorationMaterialItem.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601AB72 RID: 109426 RVA: 0x00275D98 File Offset: 0x00273F98
		public FKuroNpcExtraDecorationMaterialItem()
		{
		}

		// Token: 0x0601AB73 RID: 109427 RVA: 0x00275DA0 File Offset: 0x00273FA0
		[NullableContext(1)]
		public FKuroNpcExtraDecorationMaterialItem(int SlotID, UMaterialInterface Material)
		{
			this.SlotID = SlotID;
			this.Material = Material;
		}

		// Token: 0x0601AB74 RID: 109428 RVA: 0x00275DB6 File Offset: 0x00273FB6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNpcExtraDecorationMaterialItem.StaticStruct();
		}

		// Token: 0x0601AB75 RID: 109429 RVA: 0x00275DC2 File Offset: 0x00273FC2
		[NullableContext(2)]
		public FKuroNpcExtraDecorationMaterialItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AB76 RID: 109430 RVA: 0x00275DCC File Offset: 0x00273FCC
		public FKuroNpcExtraDecorationMaterialItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AB77 RID: 109431 RVA: 0x00275DD7 File Offset: 0x00273FD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNpcExtraDecorationMaterialItem(Pointer, false, true);
		}

		// Token: 0x0601AB78 RID: 109432 RVA: 0x00275DE1 File Offset: 0x00273FE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNpcExtraDecorationMaterialItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400E73D RID: 59197
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMaterialItem";

		// Token: 0x0400E73E RID: 59198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E73F RID: 59199
		internal static int __PropertyOffset_SlotID;

		// Token: 0x0400E740 RID: 59200
		internal static int __PropertyOffset_Material;
	}
}
