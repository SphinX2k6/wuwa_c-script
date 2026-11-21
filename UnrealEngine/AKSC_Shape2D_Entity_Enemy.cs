using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058C RID: 1420
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class AKSC_Shape2D_Entity_Enemy : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080A2 RID: 32930 RVA: 0x000BDFE8 File Offset: 0x000BC1E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Enemy._ClassPtr;
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x000BDFF4 File Offset: 0x000BC1F4
		public AKSC_Shape2D_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x000BE01C File Offset: 0x000BC21C
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x000BE04F File Offset: 0x000BC24F
		static AKSC_Shape2D_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy");
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x000BE05D File Offset: 0x000BC25D
		protected AKSC_Shape2D_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400382C RID: 14380
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Enemy";

		// Token: 0x0400382D RID: 14381
		private static IntPtr _ClassPtr;

		// Token: 0x0400382E RID: 14382
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
