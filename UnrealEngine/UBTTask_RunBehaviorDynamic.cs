using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000161 RID: 353
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_RunBehaviorDynamic")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UBTTask_RunBehaviorDynamic : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001805 RID: 6149 RVA: 0x0002361B File Offset: 0x0002181B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunBehaviorDynamic._ClassPtr;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00023628 File Offset: 0x00021828
		public UBTTask_RunBehaviorDynamic() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00023650 File Offset: 0x00021850
		[NullableContext(1)]
		public UBTTask_RunBehaviorDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehaviorDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00023683 File Offset: 0x00021883
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x00023697 File Offset: 0x00021897
		public unsafe FGameplayTag InjectionTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_RunBehaviorDynamic.__PropertyOffset_InjectionTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_RunBehaviorDynamic.__PropertyOffset_InjectionTag) = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x000236AC File Offset: 0x000218AC
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x000236C0 File Offset: 0x000218C0
		public unsafe UBehaviorTree DefaultBehaviorAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehaviorDynamic.__PropertyOffset_DefaultBehaviorAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehaviorDynamic.__PropertyOffset_DefaultBehaviorAsset, value);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x000236D5 File Offset: 0x000218D5
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x000236E9 File Offset: 0x000218E9
		public unsafe UBehaviorTree BehaviorAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehaviorDynamic.__PropertyOffset_BehaviorAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehaviorDynamic.__PropertyOffset_BehaviorAsset, value);
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000236FE File Offset: 0x000218FE
		static UBTTask_RunBehaviorDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_RunBehaviorDynamic");
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0002370C File Offset: 0x0002190C
		protected UBTTask_RunBehaviorDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005EA RID: 1514
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_RunBehaviorDynamic";

		// Token: 0x040005EB RID: 1515
		private static IntPtr _ClassPtr;

		// Token: 0x040005EC RID: 1516
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005ED RID: 1517
		internal static int __PropertyOffset_InjectionTag;

		// Token: 0x040005EE RID: 1518
		internal static int __PropertyOffset_DefaultBehaviorAsset;

		// Token: 0x040005EF RID: 1519
		internal static int __PropertyOffset_BehaviorAsset;
	}
}
