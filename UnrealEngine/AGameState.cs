using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C02 RID: 3074
	[UnrealObjectPath("/Script/Engine.GameState")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class AGameState : AGameStateBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099C8 RID: 39368 RVA: 0x000DB39C File Offset: 0x000D959C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameState._ClassPtr;
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x000DB3A8 File Offset: 0x000D95A8
		public AGameState() : this(BuiltinUtils.AllocNativeUObject(AGameState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x000DB3D0 File Offset: 0x000D95D0
		[NullableContext(1)]
		public AGameState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x060099CB RID: 39371 RVA: 0x000DB403 File Offset: 0x000D9603
		// (set) Token: 0x060099CC RID: 39372 RVA: 0x000DB417 File Offset: 0x000D9617
		public unsafe FName MatchState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_MatchState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_MatchState) = value;
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060099CD RID: 39373 RVA: 0x000DB42C File Offset: 0x000D962C
		// (set) Token: 0x060099CE RID: 39374 RVA: 0x000DB440 File Offset: 0x000D9640
		public unsafe FName PreviousMatchState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_PreviousMatchState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_PreviousMatchState) = value;
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x060099CF RID: 39375 RVA: 0x000DB455 File Offset: 0x000D9655
		// (set) Token: 0x060099D0 RID: 39376 RVA: 0x000DB465 File Offset: 0x000D9665
		public unsafe int ElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_ElapsedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameState.__PropertyOffset_ElapsedTime) = value;
			}
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x000DB476 File Offset: 0x000D9676
		public void OnRep_MatchState()
		{
			AGameState.__OnRep_MatchState_Internal(base.NativePtr);
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x000DB483 File Offset: 0x000D9683
		public void OnRep_ElapsedTime()
		{
			AGameState.__OnRep_ElapsedTime_Internal(base.NativePtr);
		}

		// Token: 0x060099D3 RID: 39379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_MatchState_Internal(IntPtr @this);

		// Token: 0x060099D4 RID: 39380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ElapsedTime_Internal(IntPtr @this);

		// Token: 0x060099D5 RID: 39381 RVA: 0x000DB490 File Offset: 0x000D9690
		static AGameState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameState");
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x000DB49E File Offset: 0x000D969E
		protected AGameState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005541 RID: 21825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameState";

		// Token: 0x04005542 RID: 21826
		private static IntPtr _ClassPtr;

		// Token: 0x04005543 RID: 21827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005544 RID: 21828
		internal static int __PropertyOffset_MatchState;

		// Token: 0x04005545 RID: 21829
		internal static int __PropertyOffset_PreviousMatchState;

		// Token: 0x04005546 RID: 21830
		internal static int __PropertyOffset_ElapsedTime;
	}
}
