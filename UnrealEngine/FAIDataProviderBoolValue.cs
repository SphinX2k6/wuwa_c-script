using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E5 RID: 229
	[UnrealObjectPath("/Script/AIModule.AIDataProviderBoolValue")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAIDataProviderBoolValue : FAIDataProviderTypedValue, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x0001B57D File Offset: 0x0001977D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDataProviderBoolValue._ScriptStructPtr != 0) ? FAIDataProviderBoolValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDataProviderBoolValue", ref FAIDataProviderBoolValue._ScriptStructPtr);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x0001B5A1 File Offset: 0x000197A1
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x0001B5B1 File Offset: 0x000197B1
		public unsafe bool DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDataProviderBoolValue.__PropertyOffset_DefaultValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDataProviderBoolValue.__PropertyOffset_DefaultValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0001B5C2 File Offset: 0x000197C2
		public FAIDataProviderBoolValue()
		{
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0001B5CA File Offset: 0x000197CA
		[NullableContext(1)]
		public FAIDataProviderBoolValue(bool DefaultValue, UClassStackOnlyPtr PropertyType_DEPRECATED, UAIDataProvider DataBinding, FName DataField)
		{
			this.DefaultValue = DefaultValue;
			base.PropertyType_DEPRECATED = PropertyType_DEPRECATED;
			base.DataBinding = DataBinding;
			base.DataField = DataField;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0001B5EF File Offset: 0x000197EF
		protected override IntPtr GetUStructPtr()
		{
			return FAIDataProviderBoolValue.StaticStruct();
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0001B5FB File Offset: 0x000197FB
		[NullableContext(2)]
		public FAIDataProviderBoolValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0001B605 File Offset: 0x00019805
		public FAIDataProviderBoolValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0001B610 File Offset: 0x00019810
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDataProviderBoolValue(Pointer, false, true);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0001B61A File Offset: 0x0001981A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDataProviderBoolValue(Pointer, MemoryOwner);
		}

		// Token: 0x04000323 RID: 803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProviderBoolValue";

		// Token: 0x04000324 RID: 804
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000325 RID: 805
		internal static int __PropertyOffset_DefaultValue;
	}
}
