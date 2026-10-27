using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019D RID: 413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryInstanceBlueprintWrapper")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UEnvQueryInstanceBlueprintWrapper : UObject, IUnrealUObject, IUnrealObject, IEQSQueryResultSourceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x00025F3A File Offset: 0x0002413A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryInstanceBlueprintWrapper._ClassPtr;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00025F46 File Offset: 0x00024146
		int IEQSQueryResultSourceInterface.InterfaceOffset()
		{
			return UEnvQueryInstanceBlueprintWrapper.__InterfaceOffset_IEQSQueryResultSourceInterface;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00025F50 File Offset: 0x00024150
		public UEnvQueryInstanceBlueprintWrapper() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryInstanceBlueprintWrapper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00025F78 File Offset: 0x00024178
		public UEnvQueryInstanceBlueprintWrapper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryInstanceBlueprintWrapper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00025FAB File Offset: 0x000241AB
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x00025FBB File Offset: 0x000241BB
		public unsafe int QueryID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_QueryID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_QueryID) = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00025FCC File Offset: 0x000241CC
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x00025FE0 File Offset: 0x000241E0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryItemType> ItemType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_ItemType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_ItemType) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00025FF5 File Offset: 0x000241F5
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x00026005 File Offset: 0x00024205
		public unsafe int OptionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_OptionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_OptionIndex) = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00026018 File Offset: 0x00024218
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00026051 File Offset: 0x00024251
		public FEQSQueryDoneSignature OnQueryFinishedEvent
		{
			get
			{
				base.FastCheckIsValid();
				FEQSQueryDoneSignature result;
				if ((result = this._OnQueryFinishedEvent) == null)
				{
					result = (this._OnQueryFinishedEvent = new FEQSQueryDoneSignature(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_OnQueryFinishedEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UEnvQueryInstanceBlueprintWrapper.__PropertyOffset_OnQueryFinishedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00026072 File Offset: 0x00024272
		public void SetNamedParam(FName ParamName, float Value)
		{
			UEnvQueryInstanceBlueprintWrapper.__SetNamedParam_Internal(base.NativePtr, ParamName, Value);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00026081 File Offset: 0x00024281
		public TArray<FVector> GetResultsAsLocations()
		{
			return new TArray<FVector>(UEnvQueryInstanceBlueprintWrapper.__GetResultsAsLocations_Internal(base.NativePtr), null);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00026094 File Offset: 0x00024294
		public TArray<AActor> GetResultsAsActors()
		{
			return new TArray<AActor>(UEnvQueryInstanceBlueprintWrapper.__GetResultsAsActors_Internal(base.NativePtr), null);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000260A7 File Offset: 0x000242A7
		[NullableContext(2)]
		public bool GetQueryResultsAsLocations(ref TArray<FVector> ResultLocations)
		{
			return UEnvQueryInstanceBlueprintWrapper.__GetQueryResultsAsLocations_Internal(base.NativePtr, (ResultLocations ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000260C4 File Offset: 0x000242C4
		public bool GetQueryResultsAsActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ResultActors)
		{
			return UEnvQueryInstanceBlueprintWrapper.__GetQueryResultsAsActors_Internal(base.NativePtr, (ResultActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000260E1 File Offset: 0x000242E1
		public float GetItemScore(int ItemIndex)
		{
			return UEnvQueryInstanceBlueprintWrapper.__GetItemScore_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x0600199E RID: 6558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNamedParam_Internal(IntPtr @this, FName ParamName, float Value);

		// Token: 0x0600199F RID: 6559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetResultsAsLocations_Internal(IntPtr @this);

		// Token: 0x060019A0 RID: 6560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetResultsAsActors_Internal(IntPtr @this);

		// Token: 0x060019A1 RID: 6561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetQueryResultsAsLocations_Internal(IntPtr @this, IntPtr ResultLocations);

		// Token: 0x060019A2 RID: 6562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetQueryResultsAsActors_Internal(IntPtr @this, IntPtr ResultActors);

		// Token: 0x060019A3 RID: 6563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetItemScore_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060019A4 RID: 6564 RVA: 0x000260EF File Offset: 0x000242EF
		static UEnvQueryInstanceBlueprintWrapper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryInstanceBlueprintWrapper");
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000260FD File Offset: 0x000242FD
		protected UEnvQueryInstanceBlueprintWrapper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400077B RID: 1915
		internal static int __InterfaceOffset_IEQSQueryResultSourceInterface;

		// Token: 0x0400077C RID: 1916
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryInstanceBlueprintWrapper";

		// Token: 0x0400077D RID: 1917
		private static IntPtr _ClassPtr;

		// Token: 0x0400077E RID: 1918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400077F RID: 1919
		public static IntPtr __EQSQueryDoneSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04000780 RID: 1920
		internal static int __PropertyOffset_QueryID;

		// Token: 0x04000781 RID: 1921
		internal static int __PropertyOffset_ItemType;

		// Token: 0x04000782 RID: 1922
		internal static int __PropertyOffset_OptionIndex;

		// Token: 0x04000783 RID: 1923
		internal static int __PropertyOffset_OnQueryFinishedEvent;

		// Token: 0x04000784 RID: 1924
		[Nullable(2)]
		private FEQSQueryDoneSignature _OnQueryFinishedEvent;
	}
}
