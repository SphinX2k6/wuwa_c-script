using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E2 RID: 6626
	[UnrealObjectPath("/Script/KuroMovement.KuroMoveBoxTrigger")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroMoveBoxTrigger : AKuroMoveTrigger, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018970 RID: 100720 RVA: 0x002435F6 File Offset: 0x002417F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroMoveBoxTrigger._ClassPtr;
		}

		// Token: 0x06018971 RID: 100721 RVA: 0x00243604 File Offset: 0x00241804
		public AKuroMoveBoxTrigger() : this(BuiltinUtils.AllocNativeUObject(AKuroMoveBoxTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018972 RID: 100722 RVA: 0x0024362C File Offset: 0x0024182C
		[NullableContext(1)]
		public AKuroMoveBoxTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroMoveBoxTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x06018973 RID: 100723 RVA: 0x0024365F File Offset: 0x0024185F
		// (set) Token: 0x06018974 RID: 100724 RVA: 0x00243673 File Offset: 0x00241873
		[Nullable(2)]
		public unsafe UBoxComponent BoxCollision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBoxTrigger.__PropertyOffset_BoxCollision);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroMoveBoxTrigger.__PropertyOffset_BoxCollision, value);
			}
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x00243688 File Offset: 0x00241888
		static AKuroMoveBoxTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMoveBoxTrigger");
		}

		// Token: 0x06018976 RID: 100726 RVA: 0x00243696 File Offset: 0x00241896
		protected AKuroMoveBoxTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4A4 RID: 54436
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMoveBoxTrigger";

		// Token: 0x0400D4A5 RID: 54437
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4A6 RID: 54438
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4A7 RID: 54439
		internal static int __PropertyOffset_BoxCollision;
	}
}
