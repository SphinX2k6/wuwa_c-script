using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001990 RID: 6544
	[UnrealObjectPath("/Script/KuroImposter.KuroImposterUpdater")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AKuroImposterUpdater : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018503 RID: 99587 RVA: 0x0023DB7D File Offset: 0x0023BD7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroImposterUpdater._ClassPtr;
		}

		// Token: 0x06018504 RID: 99588 RVA: 0x0023DB8C File Offset: 0x0023BD8C
		public AKuroImposterUpdater() : this(BuiltinUtils.AllocNativeUObject(AKuroImposterUpdater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018505 RID: 99589 RVA: 0x0023DBB4 File Offset: 0x0023BDB4
		[NullableContext(1)]
		public AKuroImposterUpdater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroImposterUpdater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x06018506 RID: 99590 RVA: 0x0023DBE7 File Offset: 0x0023BDE7
		// (set) Token: 0x06018507 RID: 99591 RVA: 0x0023DBF7 File Offset: 0x0023BDF7
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroImposterUpdater.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroImposterUpdater.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x06018508 RID: 99592 RVA: 0x0023DC08 File Offset: 0x0023BE08
		// (set) Token: 0x06018509 RID: 99593 RVA: 0x0023DC18 File Offset: 0x0023BE18
		public unsafe bool bSearchMainLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroImposterUpdater.__PropertyOffset_bSearchMainLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroImposterUpdater.__PropertyOffset_bSearchMainLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601850A RID: 99594 RVA: 0x0023DC29 File Offset: 0x0023BE29
		[NullableContext(2)]
		public void UpdateImposters(UDirectionalLightComponent DirLight, float DeltaTime)
		{
			AKuroImposterUpdater.__UpdateImposters_Internal(base.NativePtr, (DirLight != null) ? DirLight.NativePtr : IntPtr.Zero, DeltaTime);
		}

		// Token: 0x0601850B RID: 99595 RVA: 0x0023DC47 File Offset: 0x0023BE47
		public void FillAllInstGlobalColor()
		{
			AKuroImposterUpdater.__FillAllInstGlobalColor_Internal(base.NativePtr);
		}

		// Token: 0x0601850C RID: 99596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateImposters_Internal(IntPtr @this, IntPtr DirLight, float DeltaTime);

		// Token: 0x0601850D RID: 99597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FillAllInstGlobalColor_Internal(IntPtr @this);

		// Token: 0x0601850E RID: 99598 RVA: 0x0023DC54 File Offset: 0x0023BE54
		static AKuroImposterUpdater()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroImposter.KuroImposterUpdater");
		}

		// Token: 0x0601850F RID: 99599 RVA: 0x0023DC62 File Offset: 0x0023BE62
		protected AKuroImposterUpdater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D273 RID: 53875
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroImposter.KuroImposterUpdater";

		// Token: 0x0400D274 RID: 53876
		private static IntPtr _ClassPtr;

		// Token: 0x0400D275 RID: 53877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D276 RID: 53878
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400D277 RID: 53879
		internal static int __PropertyOffset_bSearchMainLight;
	}
}
