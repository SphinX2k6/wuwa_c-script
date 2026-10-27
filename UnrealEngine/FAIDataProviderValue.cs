using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EA RID: 234
	[UnrealObjectPath("/Script/AIModule.AIDataProviderValue")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAIDataProviderValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001291 RID: 4753 RVA: 0x0001B88B File Offset: 0x00019A8B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderValue._ScriptStructPtr != 0) ? FAIDataProviderValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderValue", ref FAIDataProviderValue._ScriptStructPtr);
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0001B8AF File Offset: 0x00019AAF
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x0001B8C3 File Offset: 0x00019AC3
		[Nullable(2)]
		public unsafe UAIDataProvider DataBinding
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAIDataProvider>(base.NativePtr / (IntPtr)sizeof(void*) + FAIDataProviderValue.__PropertyOffset_DataBinding);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIDataProviderValue.__PropertyOffset_DataBinding, value);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x0001B8EC File Offset: 0x00019AEC
		public unsafe FName DataField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDataProviderValue.__PropertyOffset_DataField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDataProviderValue.__PropertyOffset_DataField) = value;
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0001B901 File Offset: 0x00019B01
		public FAIDataProviderValue()
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0001B909 File Offset: 0x00019B09
		[NullableContext(1)]
		public FAIDataProviderValue(UAIDataProvider DataBinding, FName DataField)
		{
			this.DataBinding = DataBinding;
			this.DataField = DataField;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0001B91F File Offset: 0x00019B1F
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderValue.StaticStruct();
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0001B92B File Offset: 0x00019B2B
		[NullableContext(2)]
		public FAIDataProviderValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0001B935 File Offset: 0x00019B35
		public FAIDataProviderValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0001B940 File Offset: 0x00019B40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderValue(Pointer, false, true);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0001B94A File Offset: 0x00019B4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderValue(Pointer, MemoryOwner);
		}

		// Token: 0x04000331 RID: 817
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIDataProviderValue";

		// Token: 0x04000332 RID: 818
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000333 RID: 819
		internal static int __PropertyOffset_DataBinding;

		// Token: 0x04000334 RID: 820
		internal static int __PropertyOffset_DataField;
	}
}
