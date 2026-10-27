using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085C RID: 2140
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AsyncActionHandleSaveGame")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007374 RID: 29556 RVA: 0x000A5828 File Offset: 0x000A3A28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionHandleSaveGame._ClassPtr;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x000A5834 File Offset: 0x000A3A34
		public UAsyncActionHandleSaveGame() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionHandleSaveGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x000A585C File Offset: 0x000A3A5C
		[NullableContext(1)]
		public UAsyncActionHandleSaveGame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionHandleSaveGame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06007377 RID: 29559 RVA: 0x000A5890 File Offset: 0x000A3A90
		// (set) Token: 0x06007378 RID: 29560 RVA: 0x000A58C9 File Offset: 0x000A3AC9
		[Nullable(1)]
		public FOnAsyncHandleSaveGame Completed
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnAsyncHandleSaveGame result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnAsyncHandleSaveGame(base.NativePtr + (IntPtr)UAsyncActionHandleSaveGame.__PropertyOffset_Completed, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionHandleSaveGame.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06007379 RID: 29561 RVA: 0x000A58EA File Offset: 0x000A3AEA
		// (set) Token: 0x0600737A RID: 29562 RVA: 0x000A58FE File Offset: 0x000A3AFE
		public unsafe USaveGame SaveGameObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USaveGame>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncActionHandleSaveGame.__PropertyOffset_SaveGameObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncActionHandleSaveGame.__PropertyOffset_SaveGameObject, value);
			}
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x000A5914 File Offset: 0x000A3B14
		public unsafe static UAsyncActionHandleSaveGame AsyncSaveGameToSlot(UObject WorldContextObject, USaveGame SaveGameObject, [Nullable(1)] string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			UAsyncActionHandleSaveGame orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionHandleSaveGame>(UAsyncActionHandleSaveGame.__AsyncSaveGameToSlot_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (SaveGameObject != null) ? SaveGameObject.NativePtr : IntPtr.Zero, fstring, UserIndex));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x000A5960 File Offset: 0x000A3B60
		public unsafe static UAsyncActionHandleSaveGame AsyncLoadGameFromSlot(UObject WorldContextObject, [Nullable(1)] string SlotName, int UserIndex)
		{
			FString fstring = FString.AllocTemp(SlotName);
			UAsyncActionHandleSaveGame orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionHandleSaveGame>(UAsyncActionHandleSaveGame.__AsyncLoadGameFromSlot_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, UserIndex));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600737D RID: 29565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsyncSaveGameToSlot_Internal(IntPtr WorldContextObject, IntPtr SaveGameObject, in FString SlotName, int UserIndex);

		// Token: 0x0600737E RID: 29566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AsyncLoadGameFromSlot_Internal(IntPtr WorldContextObject, in FString SlotName, int UserIndex);

		// Token: 0x0600737F RID: 29567 RVA: 0x000A599A File Offset: 0x000A3B9A
		static UAsyncActionHandleSaveGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionHandleSaveGame");
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x000A59A8 File Offset: 0x000A3BA8
		protected UAsyncActionHandleSaveGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400378B RID: 14219
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AsyncActionHandleSaveGame";

		// Token: 0x0400378C RID: 14220
		private static IntPtr _ClassPtr;

		// Token: 0x0400378D RID: 14221
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400378E RID: 14222
		internal static int __PropertyOffset_Completed;

		// Token: 0x0400378F RID: 14223
		private FOnAsyncHandleSaveGame _Completed;

		// Token: 0x04003790 RID: 14224
		internal static int __PropertyOffset_SaveGameObject;
	}
}
