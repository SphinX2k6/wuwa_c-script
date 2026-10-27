using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008BA RID: 2234
	[UnrealObjectPath("/Script/Engine.BlueprintComponentChangedPropertyInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBlueprintComponentChangedPropertyInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A13 RID: 31251 RVA: 0x000AEA33 File Offset: 0x000ACC33
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintComponentChangedPropertyInfo._ScriptStructPtr != 0) ? FBlueprintComponentChangedPropertyInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintComponentChangedPropertyInfo", ref FBlueprintComponentChangedPropertyInfo._ScriptStructPtr);
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06007A14 RID: 31252 RVA: 0x000AEA57 File Offset: 0x000ACC57
		// (set) Token: 0x06007A15 RID: 31253 RVA: 0x000AEA6B File Offset: 0x000ACC6B
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintComponentChangedPropertyInfo.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintComponentChangedPropertyInfo.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x000AEA80 File Offset: 0x000ACC80
		// (set) Token: 0x06007A17 RID: 31255 RVA: 0x000AEA90 File Offset: 0x000ACC90
		public unsafe int ArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintComponentChangedPropertyInfo.__PropertyOffset_ArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintComponentChangedPropertyInfo.__PropertyOffset_ArrayIndex) = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06007A18 RID: 31256 RVA: 0x000AEAA1 File Offset: 0x000ACCA1
		// (set) Token: 0x06007A19 RID: 31257 RVA: 0x000AEAB5 File Offset: 0x000ACCB5
		[Nullable(2)]
		public unsafe UStruct PropertyScope
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FBlueprintComponentChangedPropertyInfo.__PropertyOffset_PropertyScope);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBlueprintComponentChangedPropertyInfo.__PropertyOffset_PropertyScope, value);
			}
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x000AEACA File Offset: 0x000ACCCA
		public FBlueprintComponentChangedPropertyInfo()
		{
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x000AEAD2 File Offset: 0x000ACCD2
		[NullableContext(1)]
		public FBlueprintComponentChangedPropertyInfo(FName PropertyName, int ArrayIndex, UStruct PropertyScope)
		{
			this.PropertyName = PropertyName;
			this.ArrayIndex = ArrayIndex;
			this.PropertyScope = PropertyScope;
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x000AEAEF File Offset: 0x000ACCEF
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintComponentChangedPropertyInfo.StaticStruct();
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x000AEAFB File Offset: 0x000ACCFB
		[NullableContext(2)]
		public FBlueprintComponentChangedPropertyInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x000AEB05 File Offset: 0x000ACD05
		public FBlueprintComponentChangedPropertyInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x000AEB10 File Offset: 0x000ACD10
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintComponentChangedPropertyInfo(Pointer, false, true);
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x000AEB1A File Offset: 0x000ACD1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintComponentChangedPropertyInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003AB4 RID: 15028
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlueprintComponentChangedPropertyInfo";

		// Token: 0x04003AB5 RID: 15029
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003AB6 RID: 15030
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x04003AB7 RID: 15031
		internal static int __PropertyOffset_ArrayIndex;

		// Token: 0x04003AB8 RID: 15032
		internal static int __PropertyOffset_PropertyScope;
	}
}
