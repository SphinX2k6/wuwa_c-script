using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B8 RID: 184
	[UnrealObjectPath("/Script/AIModule.BTTask_RunBehavior")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UBTTask_RunBehavior : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x00015CC5 File Offset: 0x00013EC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_RunBehavior._ClassPtr;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00015CD4 File Offset: 0x00013ED4
		public UBTTask_RunBehavior() : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00015CFC File Offset: 0x00013EFC
		[NullableContext(1)]
		public UBTTask_RunBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_RunBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00015D2F File Offset: 0x00013F2F
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00015D43 File Offset: 0x00013F43
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

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00015D58 File Offset: 0x00013F58
		static UBTTask_RunBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_RunBehavior");
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00015D66 File Offset: 0x00013F66
		protected UBTTask_RunBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000294 RID: 660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_RunBehavior";

		// Token: 0x04000295 RID: 661
		private static IntPtr _ClassPtr;

		// Token: 0x04000296 RID: 662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000297 RID: 663
		internal static int __PropertyOffset_BehaviorAsset;
	}
}
