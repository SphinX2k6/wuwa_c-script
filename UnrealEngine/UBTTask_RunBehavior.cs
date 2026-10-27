using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000160 RID: 352
	[UnrealObjectPath("/Script/AIModule.BTTask_RunBehavior")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_RunBehavior : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017FE RID: 6142 RVA: 0x00023573 File Offset: 0x00021773
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunBehavior._ClassPtr;
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00023580 File Offset: 0x00021780
		public UBTTask_RunBehavior() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000235A8 File Offset: 0x000217A8
		[NullableContext(1)]
		public UBTTask_RunBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x000235DB File Offset: 0x000217DB
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x000235EF File Offset: 0x000217EF
		[Nullable(2)]
		public unsafe UBehaviorTree BehaviorAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehavior.__PropertyOffset_BehaviorAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_RunBehavior.__PropertyOffset_BehaviorAsset, value);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00023604 File Offset: 0x00021804
		static UBTTask_RunBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_RunBehavior");
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00023612 File Offset: 0x00021812
		protected UBTTask_RunBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005E6 RID: 1510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_RunBehavior";

		// Token: 0x040005E7 RID: 1511
		private static IntPtr _ClassPtr;

		// Token: 0x040005E8 RID: 1512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005E9 RID: 1513
		internal static int __PropertyOffset_BehaviorAsset;
	}
}
