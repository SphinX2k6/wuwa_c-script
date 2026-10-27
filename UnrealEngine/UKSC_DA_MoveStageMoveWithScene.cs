using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9C RID: 7580
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageMoveWithScene")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_MoveStageMoveWithScene : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D003 RID: 118787 RVA: 0x002ADD07 File Offset: 0x002ABF07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageMoveWithScene._ClassPtr;
		}

		// Token: 0x0601D004 RID: 118788 RVA: 0x002ADD14 File Offset: 0x002ABF14
		public UKSC_DA_MoveStageMoveWithScene() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageMoveWithScene.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D005 RID: 118789 RVA: 0x002ADD3C File Offset: 0x002ABF3C
		[NullableContext(1)]
		public UKSC_DA_MoveStageMoveWithScene(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageMoveWithScene.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D006 RID: 118790 RVA: 0x002ADD6F File Offset: 0x002ABF6F
		static UKSC_DA_MoveStageMoveWithScene()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageMoveWithScene");
		}

		// Token: 0x0601D007 RID: 118791 RVA: 0x002ADD7D File Offset: 0x002ABF7D
		protected UKSC_DA_MoveStageMoveWithScene(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBDD RID: 64477
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageMoveWithScene";

		// Token: 0x0400FBDE RID: 64478
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBDF RID: 64479
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
