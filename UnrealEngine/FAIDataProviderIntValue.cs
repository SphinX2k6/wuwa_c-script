using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E7 RID: 231
	[UnrealObjectPath("/Script/AIModule.AIDataProviderIntValue")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAIDataProviderIntValue : FAIDataProviderTypedValue, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001275 RID: 4725 RVA: 0x0001B6C9 File Offset: 0x000198C9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderIntValue._ScriptStructPtr != 0) ? FAIDataProviderIntValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderIntValue", ref FAIDataProviderIntValue._ScriptStructPtr);
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0001B6ED File Offset: 0x000198ED
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x0001B6FD File Offset: 0x000198FD
		public unsafe int DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDataProviderIntValue.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDataProviderIntValue.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0001B70E File Offset: 0x0001990E
		public FAIDataProviderIntValue()
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0001B716 File Offset: 0x00019916
		[NullableContext(1)]
		public FAIDataProviderIntValue(int DefaultValue, UClassStackOnlyPtr PropertyType_DEPRECATED, UAIDataProvider DataBinding, FName DataField)
		{
			this.DefaultValue = DefaultValue;
			base.PropertyType_DEPRECATED = PropertyType_DEPRECATED;
			base.DataBinding = DataBinding;
			base.DataField = DataField;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0001B73B File Offset: 0x0001993B
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderIntValue.StaticStruct();
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0001B747 File Offset: 0x00019947
		[NullableContext(2)]
		public FAIDataProviderIntValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0001B751 File Offset: 0x00019951
		public FAIDataProviderIntValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0001B75C File Offset: 0x0001995C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderIntValue(Pointer, false, true);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0001B766 File Offset: 0x00019966
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderIntValue(Pointer, MemoryOwner);
		}

		// Token: 0x04000329 RID: 809
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProviderIntValue";

		// Token: 0x0400032A RID: 810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400032B RID: 811
		internal static int __PropertyOffset_DefaultValue;
	}
}
