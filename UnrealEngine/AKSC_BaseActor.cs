using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000560 RID: 1376
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BaseActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKSC_BaseActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DA1 RID: 32161 RVA: 0x000BA4A2 File Offset: 0x000B86A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_BaseActor._ClassPtr;
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x000BA4B0 File Offset: 0x000B86B0
		public AKSC_BaseActor() : this(BuiltinUtils.AllocNativeUObject(AKSC_BaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x000BA4D8 File Offset: 0x000B86D8
		[NullableContext(1)]
		public AKSC_BaseActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_BaseActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06007DA4 RID: 32164 RVA: 0x000BA50B File Offset: 0x000B870B
		// (set) Token: 0x06007DA5 RID: 32165 RVA: 0x000BA51F File Offset: 0x000B871F
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

		// Token: 0x06007DA6 RID: 32166 RVA: 0x000BA534 File Offset: 0x000B8734
		static AKSC_BaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BaseActor");
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x000BA542 File Offset: 0x000B8742
		protected AKSC_BaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036BD RID: 14013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BaseActor";

		// Token: 0x040036BE RID: 14014
		private static IntPtr _ClassPtr;

		// Token: 0x040036BF RID: 14015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036C0 RID: 14016
		internal static int __PropertyOffset_KscWorld;
	}
}
