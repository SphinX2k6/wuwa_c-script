using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010CB RID: 4299
	[UnrealObjectPath("/Script/Engine.SaveGame")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USaveGame : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F55B RID: 62811 RVA: 0x0016BA5F File Offset: 0x00169C5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USaveGame._ClassPtr;
		}

		// Token: 0x0600F55C RID: 62812 RVA: 0x0016BA6B File Offset: 0x00169C6B
		static USaveGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SaveGame");
		}

		// Token: 0x0600F55D RID: 62813 RVA: 0x0016BA7C File Offset: 0x00169C7C
		protected USaveGame() : this(BuiltinUtils.AllocNativeUObject(USaveGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F55E RID: 62814 RVA: 0x0016BAA4 File Offset: 0x00169CA4
		protected USaveGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084F0 RID: 34032
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SaveGame";

		// Token: 0x040084F1 RID: 34033
		private static IntPtr _ClassPtr;

		// Token: 0x040084F2 RID: 34034
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
