using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA4 RID: 7076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSaveGame")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroSaveGame : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B0FA RID: 110842 RVA: 0x0027DF06 File Offset: 0x0027C106
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSaveGame._ClassPtr;
		}

		// Token: 0x0601B0FB RID: 110843 RVA: 0x0027DF14 File Offset: 0x0027C114
		public UKuroSaveGame() : this(BuiltinUtils.AllocNativeUObject(UKuroSaveGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B0FC RID: 110844 RVA: 0x0027DF3C File Offset: 0x0027C13C
		public UKuroSaveGame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSaveGame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C76 RID: 27766
		// (get) Token: 0x0601B0FD RID: 110845 RVA: 0x0027DF70 File Offset: 0x0027C170
		// (set) Token: 0x0601B0FE RID: 110846 RVA: 0x0027DFA9 File Offset: 0x0027C1A9
		public TMap<string, int> IntMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._IntMap) == null)
				{
					result = (this._IntMap = new TMap<string, int>(base.NativePtr + (IntPtr)UKuroSaveGame.__PropertyOffset_IntMap, this));
				}
				return result;
			}
			set
			{
				this.IntMap.CopyAssign(value);
			}
		}

		// Token: 0x17006C77 RID: 27767
		// (get) Token: 0x0601B0FF RID: 110847 RVA: 0x0027DFB8 File Offset: 0x0027C1B8
		// (set) Token: 0x0601B100 RID: 110848 RVA: 0x0027DFF1 File Offset: 0x0027C1F1
		public TMap<string, float> FloatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._FloatMap) == null)
				{
					result = (this._FloatMap = new TMap<string, float>(base.NativePtr + (IntPtr)UKuroSaveGame.__PropertyOffset_FloatMap, this));
				}
				return result;
			}
			set
			{
				this.FloatMap.CopyAssign(value);
			}
		}

		// Token: 0x17006C78 RID: 27768
		// (get) Token: 0x0601B101 RID: 110849 RVA: 0x0027E000 File Offset: 0x0027C200
		// (set) Token: 0x0601B102 RID: 110850 RVA: 0x0027E039 File Offset: 0x0027C239
		public TMap<string, string> StringMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._StringMap) == null)
				{
					result = (this._StringMap = new TMap<string, string>(base.NativePtr + (IntPtr)UKuroSaveGame.__PropertyOffset_StringMap, this));
				}
				return result;
			}
			set
			{
				this.StringMap.CopyAssign(value);
			}
		}

		// Token: 0x0601B103 RID: 110851 RVA: 0x0027E047 File Offset: 0x0027C247
		static UKuroSaveGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSaveGame");
		}

		// Token: 0x0601B104 RID: 110852 RVA: 0x0027E055 File Offset: 0x0027C255
		protected UKuroSaveGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E91D RID: 59677
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSaveGame";

		// Token: 0x0400E91E RID: 59678
		private static IntPtr _ClassPtr;

		// Token: 0x0400E91F RID: 59679
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E920 RID: 59680
		internal static int __PropertyOffset_IntMap;

		// Token: 0x0400E921 RID: 59681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _IntMap;

		// Token: 0x0400E922 RID: 59682
		internal static int __PropertyOffset_FloatMap;

		// Token: 0x0400E923 RID: 59683
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _FloatMap;

		// Token: 0x0400E924 RID: 59684
		internal static int __PropertyOffset_StringMap;

		// Token: 0x0400E925 RID: 59685
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _StringMap;
	}
}
