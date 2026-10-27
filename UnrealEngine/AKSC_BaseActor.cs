using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CFC RID: 7420
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BaseActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKSC_BaseActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C8E0 RID: 116960 RVA: 0x002A36BA File Offset: 0x002A18BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_BaseActor._ClassPtr;
		}

		// Token: 0x0601C8E1 RID: 116961 RVA: 0x002A36C8 File Offset: 0x002A18C8
		public AKSC_BaseActor() : this(BuiltinUtils.AllocNativeUObject(AKSC_BaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8E2 RID: 116962 RVA: 0x002A36F0 File Offset: 0x002A18F0
		[NullableContext(1)]
		public AKSC_BaseActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_BaseActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700730C RID: 29452
		// (get) Token: 0x0601C8E3 RID: 116963 RVA: 0x002A3723 File Offset: 0x002A1923
		// (set) Token: 0x0601C8E4 RID: 116964 RVA: 0x002A3737 File Offset: 0x002A1937
		[Nullable(2)]
		public unsafe UKSC_World KscWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_BaseActor.__PropertyOffset_KscWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_BaseActor.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x0601C8E5 RID: 116965 RVA: 0x002A374C File Offset: 0x002A194C
		static AKSC_BaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BaseActor");
		}

		// Token: 0x0601C8E6 RID: 116966 RVA: 0x002A375A File Offset: 0x002A195A
		protected AKSC_BaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7A7 RID: 63399
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BaseActor";

		// Token: 0x0400F7A8 RID: 63400
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7A9 RID: 63401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7AA RID: 63402
		internal static int __PropertyOffset_KscWorld;
	}
}
