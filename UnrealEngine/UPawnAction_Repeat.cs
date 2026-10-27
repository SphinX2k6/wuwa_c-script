using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DA RID: 474
	[UnrealObjectPath("/Script/AIModule.PawnAction_Repeat")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UPawnAction_Repeat : UPawnAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x00029C19 File Offset: 0x00027E19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction_Repeat._ClassPtr;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00029C28 File Offset: 0x00027E28
		public UPawnAction_Repeat() : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Repeat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00029C50 File Offset: 0x00027E50
		[NullableContext(1)]
		public UPawnAction_Repeat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Repeat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00029C83 File Offset: 0x00027E83
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x00029C97 File Offset: 0x00027E97
		[Nullable(2)]
		public unsafe UPawnAction ActionToRepeat
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Repeat.__PropertyOffset_ActionToRepeat);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Repeat.__PropertyOffset_ActionToRepeat, value);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00029CAC File Offset: 0x00027EAC
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00029CC0 File Offset: 0x00027EC0
		[Nullable(2)]
		public unsafe UPawnAction RecentActionCopy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Repeat.__PropertyOffset_RecentActionCopy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Repeat.__PropertyOffset_RecentActionCopy, value);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x00029CD5 File Offset: 0x00027ED5
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00029CE9 File Offset: 0x00027EE9
		public unsafe TEnumAsByte<EPawnActionFailHandling> ChildFailureHandlingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Repeat.__PropertyOffset_ChildFailureHandlingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Repeat.__PropertyOffset_ChildFailureHandlingMode) = value;
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00029CFE File Offset: 0x00027EFE
		static UPawnAction_Repeat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction_Repeat");
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00029D0C File Offset: 0x00027F0C
		protected UPawnAction_Repeat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400090F RID: 2319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction_Repeat";

		// Token: 0x04000910 RID: 2320
		private static IntPtr _ClassPtr;

		// Token: 0x04000911 RID: 2321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000912 RID: 2322
		internal static int __PropertyOffset_ActionToRepeat;

		// Token: 0x04000913 RID: 2323
		internal static int __PropertyOffset_RecentActionCopy;

		// Token: 0x04000914 RID: 2324
		internal static int __PropertyOffset_ChildFailureHandlingMode;
	}
}
