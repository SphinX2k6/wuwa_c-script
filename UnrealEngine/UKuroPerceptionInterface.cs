using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001900 RID: 6400
	[UnrealObjectPath("/Script/KuroGameplay.KuroPerceptionInterface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerceptionInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017BFA RID: 97274 RVA: 0x0022CADF File Offset: 0x0022ACDF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerceptionInterface._ClassPtr;
		}

		// Token: 0x06017BFB RID: 97275 RVA: 0x0022CAEC File Offset: 0x0022ACEC
		public UKuroPerceptionInterface() : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017BFC RID: 97276 RVA: 0x0022CB14 File Offset: 0x0022AD14
		[NullableContext(1)]
		public UKuroPerceptionInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017BFD RID: 97277
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdatePerceptionRange(uint RangeToken, float Range);

		// Token: 0x06017BFE RID: 97278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdatePerceptionEventDistance(uint Token, float EnterDistance, float LeaveDistance);

		// Token: 0x06017BFF RID: 97279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterPlayerPerceptionEvent(uint Token);

		// Token: 0x06017C00 RID: 97280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemovePerceptionRange(uint RangeToken);

		// Token: 0x06017C01 RID: 97281
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RefreshDynamicPerceptionRange(uint RangeToken);

		// Token: 0x06017C02 RID: 97282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkElementDisable(uint Token, bool bIsDisable);

		// Token: 0x06017C03 RID: 97283 RVA: 0x0022CB47 File Offset: 0x0022AD47
		[NullableContext(2)]
		public static void InitializeEnvironment(ushort GridWidth, ushort GridHeight, in TMap<FName, uint> Groups, bool OnlyPlayer, bool OnlyCSharpEnv)
		{
			UKuroPerceptionInterface.__InitializeEnvironment_Internal(GridWidth, GridHeight, (Groups ?? new TMap<FName, uint>()).NativeMapPtr, OnlyPlayer, OnlyCSharpEnv);
		}

		// Token: 0x06017C04 RID: 97284 RVA: 0x0022CB63 File Offset: 0x0022AD63
		[NullableContext(1)]
		public static string GetPlayerPerceptionDebugString(uint Token)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroPerceptionInterface.__GetPlayerPerceptionDebugString_Internal(Token));
		}

		// Token: 0x06017C05 RID: 97285
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06017C06 RID: 97286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEnvironment_Internal(ushort GridWidth, ushort GridHeight, IntPtr Groups, bool OnlyPlayer, bool OnlyCSharpEnv);

		// Token: 0x06017C07 RID: 97287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlayerPerceptionDebugString_Internal(uint Token);

		// Token: 0x06017C08 RID: 97288 RVA: 0x0022CB70 File Offset: 0x0022AD70
		static UKuroPerceptionInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroPerceptionInterface");
		}

		// Token: 0x06017C09 RID: 97289 RVA: 0x0022CB7E File Offset: 0x0022AD7E
		protected UKuroPerceptionInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE2D RID: 52781
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroPerceptionInterface";

		// Token: 0x0400CE2E RID: 52782
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE2F RID: 52783
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
