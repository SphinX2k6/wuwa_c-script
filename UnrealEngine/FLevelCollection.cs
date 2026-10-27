using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D26 RID: 3366
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelCollection")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FLevelCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B494 RID: 46228 RVA: 0x001018C8 File Offset: 0x000FFAC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelCollection._ScriptStructPtr != 0) ? FLevelCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelCollection", ref FLevelCollection._ScriptStructPtr);
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600B495 RID: 46229 RVA: 0x001018EC File Offset: 0x000FFAEC
		// (set) Token: 0x0600B496 RID: 46230 RVA: 0x00101900 File Offset: 0x000FFB00
		public unsafe AGameStateBase GameState
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameStateBase>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_GameState);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_GameState, value);
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x0600B497 RID: 46231 RVA: 0x00101915 File Offset: 0x000FFB15
		// (set) Token: 0x0600B498 RID: 46232 RVA: 0x00101929 File Offset: 0x000FFB29
		public unsafe UNetDriver NetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_NetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_NetDriver, value);
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x0010193E File Offset: 0x000FFB3E
		// (set) Token: 0x0600B49A RID: 46234 RVA: 0x00101952 File Offset: 0x000FFB52
		public unsafe UDemoNetDriver DemoNetDriver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDemoNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_DemoNetDriver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_DemoNetDriver, value);
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x0600B49B RID: 46235 RVA: 0x00101967 File Offset: 0x000FFB67
		// (set) Token: 0x0600B49C RID: 46236 RVA: 0x0010197B File Offset: 0x000FFB7B
		public unsafe ULevel PersistentLevel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_PersistentLevel);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLevelCollection.__PropertyOffset_PersistentLevel, value);
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x0600B49D RID: 46237 RVA: 0x00101990 File Offset: 0x000FFB90
		// (set) Token: 0x0600B49E RID: 46238 RVA: 0x001019D3 File Offset: 0x000FFBD3
		[Nullable(1)]
		public TSet<ULevel> Levels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<ULevel> result;
				if ((result = this._Levels) == null)
				{
					result = (this._Levels = new TSet<ULevel>(base.NativePtr + (IntPtr)FLevelCollection.__PropertyOffset_Levels, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Levels.CopyAssign(value);
			}
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x001019E1 File Offset: 0x000FFBE1
		public FLevelCollection()
		{
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x001019E9 File Offset: 0x000FFBE9
		[NullableContext(1)]
		public FLevelCollection(AGameStateBase GameState, UNetDriver NetDriver, UDemoNetDriver DemoNetDriver, ULevel PersistentLevel, TSet<ULevel> Levels)
		{
			this.GameState = GameState;
			this.NetDriver = NetDriver;
			this.DemoNetDriver = DemoNetDriver;
			this.PersistentLevel = PersistentLevel;
			this.Levels = Levels;
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x00101A16 File Offset: 0x000FFC16
		protected override IntPtr GetUStructPtr()
		{
			return FLevelCollection.StaticStruct();
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x00101A22 File Offset: 0x000FFC22
		public FLevelCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x00101A2C File Offset: 0x000FFC2C
		public FLevelCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x00101A37 File Offset: 0x000FFC37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelCollection(Pointer, false, true);
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x00101A41 File Offset: 0x000FFC41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04005EEF RID: 24303
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelCollection";

		// Token: 0x04005EF0 RID: 24304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EF1 RID: 24305
		internal static int __PropertyOffset_GameState;

		// Token: 0x04005EF2 RID: 24306
		internal static int __PropertyOffset_NetDriver;

		// Token: 0x04005EF3 RID: 24307
		internal static int __PropertyOffset_DemoNetDriver;

		// Token: 0x04005EF4 RID: 24308
		internal static int __PropertyOffset_PersistentLevel;

		// Token: 0x04005EF5 RID: 24309
		internal static int __PropertyOffset_Levels;

		// Token: 0x04005EF6 RID: 24310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<ULevel> _Levels;
	}
}
