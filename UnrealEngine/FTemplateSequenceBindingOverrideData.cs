using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002908 RID: 10504
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequenceBindingOverrideData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FTemplateSequenceBindingOverrideData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026F68 RID: 159592 RVA: 0x003B6D01 File Offset: 0x003B4F01
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTemplateSequenceBindingOverrideData._ScriptStructPtr != 0) ? FTemplateSequenceBindingOverrideData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TemplateSequence.TemplateSequenceBindingOverrideData", ref FTemplateSequenceBindingOverrideData._ScriptStructPtr);
		}

		// Token: 0x1700960C RID: 38412
		// (get) Token: 0x06026F69 RID: 159593 RVA: 0x003B6D25 File Offset: 0x003B4F25
		// (set) Token: 0x06026F6A RID: 159594 RVA: 0x003B6D39 File Offset: 0x003B4F39
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> Object
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FTemplateSequenceBindingOverrideData.__PropertyOffset_Object);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FTemplateSequenceBindingOverrideData.__PropertyOffset_Object) = value;
			}
		}

		// Token: 0x1700960D RID: 38413
		// (get) Token: 0x06026F6B RID: 159595 RVA: 0x003B6D4E File Offset: 0x003B4F4E
		// (set) Token: 0x06026F6C RID: 159596 RVA: 0x003B6D5E File Offset: 0x003B4F5E
		public unsafe bool bOverridesDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTemplateSequenceBindingOverrideData.__PropertyOffset_bOverridesDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTemplateSequenceBindingOverrideData.__PropertyOffset_bOverridesDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026F6D RID: 159597 RVA: 0x003B6D6F File Offset: 0x003B4F6F
		public FTemplateSequenceBindingOverrideData()
		{
		}

		// Token: 0x06026F6E RID: 159598 RVA: 0x003B6D77 File Offset: 0x003B4F77
		public FTemplateSequenceBindingOverrideData([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> Object, bool bOverridesDefault)
		{
			this.Object = Object;
			this.bOverridesDefault = bOverridesDefault;
		}

		// Token: 0x06026F6F RID: 159599 RVA: 0x003B6D8D File Offset: 0x003B4F8D
		protected override IntPtr GetUStructPtr()
		{
			return FTemplateSequenceBindingOverrideData.StaticStruct();
		}

		// Token: 0x06026F70 RID: 159600 RVA: 0x003B6D99 File Offset: 0x003B4F99
		[NullableContext(2)]
		public FTemplateSequenceBindingOverrideData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026F71 RID: 159601 RVA: 0x003B6DA3 File Offset: 0x003B4FA3
		public FTemplateSequenceBindingOverrideData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026F72 RID: 159602 RVA: 0x003B6DAE File Offset: 0x003B4FAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTemplateSequenceBindingOverrideData(Pointer, false, true);
		}

		// Token: 0x06026F73 RID: 159603 RVA: 0x003B6DB8 File Offset: 0x003B4FB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTemplateSequenceBindingOverrideData(Pointer, MemoryOwner);
		}

		// Token: 0x04015623 RID: 87587
		[Nullable(1)]
		public const string __ObjectPath = "/Script/TemplateSequence.TemplateSequenceBindingOverrideData";

		// Token: 0x04015624 RID: 87588
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015625 RID: 87589
		internal static int __PropertyOffset_Object;

		// Token: 0x04015626 RID: 87590
		internal static int __PropertyOffset_bOverridesDefault;
	}
}
