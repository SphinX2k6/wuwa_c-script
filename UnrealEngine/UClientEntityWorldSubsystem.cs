using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000937 RID: 2359
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientEntityWorldSubsystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UClientEntityWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008543 RID: 34115 RVA: 0x000BE0E8 File Offset: 0x000BC2E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClientEntityWorldSubsystem._ClassPtr;
		}

		// Token: 0x06008544 RID: 34116 RVA: 0x000BE0F4 File Offset: 0x000BC2F4
		public UClientEntityWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UClientEntityWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008545 RID: 34117 RVA: 0x000BE11C File Offset: 0x000BC31C
		public UClientEntityWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClientEntityWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06008546 RID: 34118 RVA: 0x000BE150 File Offset: 0x000BC350
		// (set) Token: 0x06008547 RID: 34119 RVA: 0x000BE189 File Offset: 0x000BC389
		public FOnClientEntityStreamingStateChanged OnClientEntityStreamingStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnClientEntityStreamingStateChanged result;
				if ((result = this._OnClientEntityStreamingStateChanged) == null)
				{
					result = (this._OnClientEntityStreamingStateChanged = new FOnClientEntityStreamingStateChanged(base.NativePtr + (IntPtr)UClientEntityWorldSubsystem.__PropertyOffset_OnClientEntityStreamingStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UClientEntityWorldSubsystem.__PropertyOffset_OnClientEntityStreamingStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x000BE1AA File Offset: 0x000BC3AA
		[NullableContext(2)]
		public void SetValidPackIds(in TArray<int> InPackIds)
		{
			UClientEntityWorldSubsystem.__SetValidPackIds_Internal(base.NativePtr, (InPackIds ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06008549 RID: 34121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValidPackIds_Internal(IntPtr @this, IntPtr InPackIds);

		// Token: 0x0600854A RID: 34122 RVA: 0x000BE1C7 File Offset: 0x000BC3C7
		static UClientEntityWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ClientEntityWorldSubsystem");
		}

		// Token: 0x0600854B RID: 34123 RVA: 0x000BE1D5 File Offset: 0x000BC3D5
		protected UClientEntityWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F6B RID: 16235
		public new const string __ObjectPath = "/Script/Engine.ClientEntityWorldSubsystem";

		// Token: 0x04003F6C RID: 16236
		private static IntPtr _ClassPtr;

		// Token: 0x04003F6D RID: 16237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F6E RID: 16238
		internal static int __PropertyOffset_OnClientEntityStreamingStateChanged;

		// Token: 0x04003F6F RID: 16239
		[Nullable(2)]
		private FOnClientEntityStreamingStateChanged _OnClientEntityStreamingStateChanged;
	}
}
