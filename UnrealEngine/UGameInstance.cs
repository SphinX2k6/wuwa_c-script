using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000213 RID: 531
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameInstance")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UGameInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x00031DB1 File Offset: 0x0002FFB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameInstance._ClassPtr;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		public UGameInstance() : this(BuiltinUtils.AllocNativeUObject(UGameInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00031DE8 File Offset: 0x0002FFE8
		public UGameInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00031E1C File Offset: 0x0003001C
		// (set) Token: 0x06002216 RID: 8726 RVA: 0x00031E55 File Offset: 0x00030055
		public TArray<UObject> ReferencedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedObjects) == null)
				{
					result = (this._ReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_ReferencedObjects, this));
				}
				return result;
			}
			set
			{
				this.ReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x00031E64 File Offset: 0x00030064
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x00031E9D File Offset: 0x0003009D
		public FOnPawnControllerChanged OnPawnControllerChangedDelegates
		{
			get
			{
				base.FastCheckIsValid();
				FOnPawnControllerChanged result;
				if ((result = this._OnPawnControllerChangedDelegates) == null)
				{
					result = (this._OnPawnControllerChangedDelegates = new FOnPawnControllerChanged(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_OnPawnControllerChangedDelegates, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_OnPawnControllerChangedDelegates, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00031EBE File Offset: 0x000300BE
		public virtual void ReceiveShutdown()
		{
			UGameInstance.__ReceiveShutdown_Internal(base.NativePtr);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00031ECB File Offset: 0x000300CB
		public virtual void ReceiveInit()
		{
			UGameInstance.__ReceiveInit_Internal(base.NativePtr);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00031ED8 File Offset: 0x000300D8
		public void DebugRemovePlayer(int ControllerId)
		{
			UGameInstance.__DebugRemovePlayer_Internal(base.NativePtr, ControllerId);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00031EE6 File Offset: 0x000300E6
		public void DebugCreatePlayer(int ControllerId)
		{
			UGameInstance.__DebugCreatePlayer_Internal(base.NativePtr, ControllerId);
		}

		// Token: 0x0600221D RID: 8733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveShutdown_Internal(IntPtr @this);

		// Token: 0x0600221E RID: 8734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveInit_Internal(IntPtr @this);

		// Token: 0x0600221F RID: 8735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugRemovePlayer_Internal(IntPtr @this, int ControllerId);

		// Token: 0x06002220 RID: 8736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCreatePlayer_Internal(IntPtr @this, int ControllerId);

		// Token: 0x06002221 RID: 8737 RVA: 0x00031EF4 File Offset: 0x000300F4
		static UGameInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameInstance");
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00031F02 File Offset: 0x00030102
		protected UGameInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D54 RID: 3412
		public new const string __ObjectPath = "/Script/Engine.GameInstance";

		// Token: 0x04000D55 RID: 3413
		private static IntPtr _ClassPtr;

		// Token: 0x04000D56 RID: 3414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D57 RID: 3415
		internal static int __PropertyOffset_ReferencedObjects;

		// Token: 0x04000D58 RID: 3416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedObjects;

		// Token: 0x04000D59 RID: 3417
		internal static int __PropertyOffset_OnPawnControllerChangedDelegates;

		// Token: 0x04000D5A RID: 3418
		[Nullable(2)]
		private FOnPawnControllerChanged _OnPawnControllerChangedDelegates;
	}
}
