using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E6 RID: 230
	[UnrealObjectPath("/Script/AIModule.AIDataProviderFloatValue")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAIDataProviderFloatValue : FAIDataProviderTypedValue, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x0001B623 File Offset: 0x00019823
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderFloatValue._ScriptStructPtr != 0) ? FAIDataProviderFloatValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderFloatValue", ref FAIDataProviderFloatValue._ScriptStructPtr);
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0001B647 File Offset: 0x00019847
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x0001B657 File Offset: 0x00019857
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDataProviderFloatValue.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDataProviderFloatValue.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0001B668 File Offset: 0x00019868
		public FAIDataProviderFloatValue()
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0001B670 File Offset: 0x00019870
		[NullableContext(1)]
		public FAIDataProviderFloatValue(float DefaultValue, UClassStackOnlyPtr PropertyType_DEPRECATED, UAIDataProvider DataBinding, FName DataField)
		{
			this.DefaultValue = DefaultValue;
			base.PropertyType_DEPRECATED = PropertyType_DEPRECATED;
			base.DataBinding = DataBinding;
			base.DataField = DataField;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0001B695 File Offset: 0x00019895
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderFloatValue.StaticStruct();
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0001B6A1 File Offset: 0x000198A1
		[NullableContext(2)]
		public FAIDataProviderFloatValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0001B6AB File Offset: 0x000198AB
		public FAIDataProviderFloatValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0001B6B6 File Offset: 0x000198B6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderFloatValue(Pointer, false, true);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0001B6C0 File Offset: 0x000198C0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderFloatValue(Pointer, MemoryOwner);
		}

		// Token: 0x04000326 RID: 806
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProviderFloatValue";

		// Token: 0x04000327 RID: 807
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000328 RID: 808
		internal static int __PropertyOffset_DefaultValue;
	}
}
