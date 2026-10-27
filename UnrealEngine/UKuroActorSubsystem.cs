using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CDE RID: 3294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroActorSubsystem")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKuroActorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AEA9 RID: 44713 RVA: 0x000F7C92 File Offset: 0x000F5E92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorSubsystem._ClassPtr;
		}

		// Token: 0x0600AEAA RID: 44714 RVA: 0x000F7CA0 File Offset: 0x000F5EA0
		public UKuroActorSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroActorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AEAB RID: 44715 RVA: 0x000F7CC8 File Offset: 0x000F5EC8
		public UKuroActorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x000F7CFC File Offset: 0x000F5EFC
		// (set) Token: 0x0600AEAD RID: 44717 RVA: 0x000F7D35 File Offset: 0x000F5F35
		public FActorSubsystemDelegate OnAddToSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FActorSubsystemDelegate result;
				if ((result = this._OnAddToSubsystem) == null)
				{
					result = (this._OnAddToSubsystem = new FActorSubsystemDelegate(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnAddToSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnAddToSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600AEAE RID: 44718 RVA: 0x000F7D58 File Offset: 0x000F5F58
		// (set) Token: 0x0600AEAF RID: 44719 RVA: 0x000F7D91 File Offset: 0x000F5F91
		public FActorSubsystemDelegate OnRemoveFromSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FActorSubsystemDelegate result;
				if ((result = this._OnRemoveFromSubsystem) == null)
				{
					result = (this._OnRemoveFromSubsystem = new FActorSubsystemDelegate(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnRemoveFromSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnRemoveFromSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x000F7DB2 File Offset: 0x000F5FB2
		public void UnRegisterEntity(int EntityId)
		{
			UKuroActorSubsystem.__UnRegisterEntity_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x000F7DC0 File Offset: 0x000F5FC0
		public void RegisterEntity(int EntityId, bool bPreAwake = false)
		{
			UKuroActorSubsystem.__RegisterEntity_Internal(base.NativePtr, EntityId, bPreAwake);
		}

		// Token: 0x0600AEB2 RID: 44722 RVA: 0x000F7DCF File Offset: 0x000F5FCF
		public void RecordEntityModifiedActor(int EntityId)
		{
			UKuroActorSubsystem.__RecordEntityModifiedActor_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0600AEB3 RID: 44723 RVA: 0x000F7DE0 File Offset: 0x000F5FE0
		public unsafe bool GetActorOriginalTransform(FName ActorKey, ref FTransform OutTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			bool result = UKuroActorSubsystem.__GetActorOriginalTransform_Internal(base.NativePtr, ActorKey, ref ptr);
			OutTransform = ptr;
			return result;
		}

		// Token: 0x0600AEB4 RID: 44724 RVA: 0x000F7E22 File Offset: 0x000F6022
		[NullableContext(2)]
		public AActor GetActor(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroActorSubsystem.__GetActor_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x000F7E38 File Offset: 0x000F6038
		[NullableContext(2)]
		public unsafe bool D_GetActorOriginalTransform(UObject WorldContext, FName ActorKey, ref FTransformDouble OutTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			bool result = UKuroActorSubsystem.__D_GetActorOriginalTransform_Internal(base.NativePtr, (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, ActorKey, ref ptr);
			OutTransform = ptr;
			return result;
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x000F7E8C File Offset: 0x000F608C
		public unsafe static bool CheckAssetPlatformInclude(string ResourcePlatformTag)
		{
			FString fstring = FString.AllocTemp(ResourcePlatformTag);
			bool result = UKuroActorSubsystem.__CheckAssetPlatformInclude_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600AEB7 RID: 44727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterEntity_Internal(IntPtr @this, int EntityId);

		// Token: 0x0600AEB8 RID: 44728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntity_Internal(IntPtr @this, int EntityId, bool bPreAwake);

		// Token: 0x0600AEB9 RID: 44729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecordEntityModifiedActor_Internal(IntPtr @this, int EntityId);

		// Token: 0x0600AEBA RID: 44730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorOriginalTransform_Internal(IntPtr @this, FName ActorKey, ref FTransform OutTransform);

		// Token: 0x0600AEBB RID: 44731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActor_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x0600AEBC RID: 44732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetActorOriginalTransform_Internal(IntPtr @this, IntPtr WorldContext, FName ActorKey, ref FTransformDouble OutTransform);

		// Token: 0x0600AEBD RID: 44733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckAssetPlatformInclude_Internal(in FString ResourcePlatformTag);

		// Token: 0x0600AEBE RID: 44734 RVA: 0x000F7EB0 File Offset: 0x000F60B0
		static UKuroActorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroActorSubsystem");
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x000F7EBE File Offset: 0x000F60BE
		protected UKuroActorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B84 RID: 23428
		public new const string __ObjectPath = "/Script/Engine.KuroActorSubsystem";

		// Token: 0x04005B85 RID: 23429
		private static IntPtr _ClassPtr;

		// Token: 0x04005B86 RID: 23430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005B87 RID: 23431
		internal static int __PropertyOffset_OnAddToSubsystem;

		// Token: 0x04005B88 RID: 23432
		[Nullable(2)]
		private FActorSubsystemDelegate _OnAddToSubsystem;

		// Token: 0x04005B89 RID: 23433
		internal static int __PropertyOffset_OnRemoveFromSubsystem;

		// Token: 0x04005B8A RID: 23434
		[Nullable(2)]
		private FActorSubsystemDelegate _OnRemoveFromSubsystem;
	}
}
