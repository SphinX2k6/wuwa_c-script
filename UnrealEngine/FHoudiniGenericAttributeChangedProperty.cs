using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C2 RID: 5314
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniGenericAttributeChangedProperty")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FHoudiniGenericAttributeChangedProperty : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060133B4 RID: 78772 RVA: 0x001C48B4 File Offset: 0x001C2AB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniGenericAttributeChangedProperty._ScriptStructPtr != 0) ? FHoudiniGenericAttributeChangedProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniGenericAttributeChangedProperty", ref FHoudiniGenericAttributeChangedProperty._ScriptStructPtr);
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x060133B5 RID: 78773 RVA: 0x001C48D8 File Offset: 0x001C2AD8
		// (set) Token: 0x060133B6 RID: 78774 RVA: 0x001C48EC File Offset: 0x001C2AEC
		[Nullable(2)]
		public unsafe UObject Object
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniGenericAttributeChangedProperty.__PropertyOffset_Object);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniGenericAttributeChangedProperty.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x060133B7 RID: 78775 RVA: 0x001C4901 File Offset: 0x001C2B01
		public FHoudiniGenericAttributeChangedProperty()
		{
		}

		// Token: 0x060133B8 RID: 78776 RVA: 0x001C4909 File Offset: 0x001C2B09
		[NullableContext(1)]
		public FHoudiniGenericAttributeChangedProperty(UObject Object)
		{
			this.Object = Object;
		}

		// Token: 0x060133B9 RID: 78777 RVA: 0x001C4918 File Offset: 0x001C2B18
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniGenericAttributeChangedProperty.StaticStruct();
		}

		// Token: 0x060133BA RID: 78778 RVA: 0x001C4924 File Offset: 0x001C2B24
		[NullableContext(2)]
		public FHoudiniGenericAttributeChangedProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060133BB RID: 78779 RVA: 0x001C492E File Offset: 0x001C2B2E
		public FHoudiniGenericAttributeChangedProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060133BC RID: 78780 RVA: 0x001C4939 File Offset: 0x001C2B39
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniGenericAttributeChangedProperty(Pointer, false, true);
		}

		// Token: 0x060133BD RID: 78781 RVA: 0x001C4943 File Offset: 0x001C2B43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniGenericAttributeChangedProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400A627 RID: 42535
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniGenericAttributeChangedProperty";

		// Token: 0x0400A628 RID: 42536
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A629 RID: 42537
		internal static int __PropertyOffset_Object;
	}
}
