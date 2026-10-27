using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002031 RID: 8241
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIComponentsRegistry")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class ULGUIComponentsRegistry : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2DD RID: 127709 RVA: 0x002E49B5 File Offset: 0x002E2BB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIComponentsRegistry._ClassPtr;
		}

		// Token: 0x0601F2DE RID: 127710 RVA: 0x002E49C4 File Offset: 0x002E2BC4
		public ULGUIComponentsRegistry() : this(BuiltinUtils.AllocNativeUObject(ULGUIComponentsRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2DF RID: 127711 RVA: 0x002E49EC File Offset: 0x002E2BEC
		public ULGUIComponentsRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIComponentsRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BA5 RID: 31653
		// (get) Token: 0x0601F2E0 RID: 127712 RVA: 0x002E4A1F File Offset: 0x002E2C1F
		// (set) Token: 0x0601F2E1 RID: 127713 RVA: 0x002E4A33 File Offset: 0x002E2C33
		public unsafe string TsClassName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIComponentsRegistry.__PropertyOffset_TsClassName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULGUIComponentsRegistry.__PropertyOffset_TsClassName)), value);
			}
		}

		// Token: 0x17007BA6 RID: 31654
		// (get) Token: 0x0601F2E2 RID: 127714 RVA: 0x002E4A48 File Offset: 0x002E2C48
		// (set) Token: 0x0601F2E3 RID: 127715 RVA: 0x002E4A81 File Offset: 0x002E2C81
		public TMap<string, FRegisterRuntimeData> RuntimeRegistryData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FRegisterRuntimeData> result;
				if ((result = this._RuntimeRegistryData) == null)
				{
					result = (this._RuntimeRegistryData = new TMap<string, FRegisterRuntimeData>(base.NativePtr + (IntPtr)ULGUIComponentsRegistry.__PropertyOffset_RuntimeRegistryData, this));
				}
				return result;
			}
			set
			{
				this.RuntimeRegistryData.CopyAssign(value);
			}
		}

		// Token: 0x17007BA7 RID: 31655
		// (get) Token: 0x0601F2E4 RID: 127716 RVA: 0x002E4A90 File Offset: 0x002E2C90
		// (set) Token: 0x0601F2E5 RID: 127717 RVA: 0x002E4AC9 File Offset: 0x002E2CC9
		public TArray<AActor> Components
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<AActor>(base.NativePtr + (IntPtr)ULGUIComponentsRegistry.__PropertyOffset_Components, this));
				}
				return result;
			}
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x17007BA8 RID: 31656
		// (get) Token: 0x0601F2E6 RID: 127718 RVA: 0x002E4AD8 File Offset: 0x002E2CD8
		// (set) Token: 0x0601F2E7 RID: 127719 RVA: 0x002E4B11 File Offset: 0x002E2D11
		public TMap<int, string> MissingComponents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, string> result;
				if ((result = this._MissingComponents) == null)
				{
					result = (this._MissingComponents = new TMap<int, string>(base.NativePtr + (IntPtr)ULGUIComponentsRegistry.__PropertyOffset_MissingComponents, this));
				}
				return result;
			}
			set
			{
				this.MissingComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601F2E8 RID: 127720 RVA: 0x002E4B1F File Offset: 0x002E2D1F
		public void SetComponents([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> NewComponents)
		{
			ULGUIComponentsRegistry.__SetComponents_Internal(base.NativePtr, (NewComponents ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x0601F2E9 RID: 127721 RVA: 0x002E4B3C File Offset: 0x002E2D3C
		public TArray<AActor> GetComponents()
		{
			return new TArray<AActor>(ULGUIComponentsRegistry.__GetComponents_Internal(base.NativePtr), null);
		}

		// Token: 0x0601F2EA RID: 127722 RVA: 0x002E4B4F File Offset: 0x002E2D4F
		[NullableContext(2)]
		public void CopyFrom(ULGUIComponentsRegistry Other)
		{
			ULGUIComponentsRegistry.__CopyFrom_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F2EB RID: 127723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponents_Internal(IntPtr @this, IntPtr NewComponents);

		// Token: 0x0601F2EC RID: 127724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponents_Internal(IntPtr @this);

		// Token: 0x0601F2ED RID: 127725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyFrom_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x0601F2EE RID: 127726 RVA: 0x002E4B6C File Offset: 0x002E2D6C
		static ULGUIComponentsRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIComponentsRegistry");
		}

		// Token: 0x0601F2EF RID: 127727 RVA: 0x002E4B7A File Offset: 0x002E2D7A
		protected ULGUIComponentsRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E0A RID: 69130
		public new const string __ObjectPath = "/Script/LGUI.LGUIComponentsRegistry";

		// Token: 0x04010E0B RID: 69131
		private static IntPtr _ClassPtr;

		// Token: 0x04010E0C RID: 69132
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E0D RID: 69133
		internal static int __PropertyOffset_TsClassName;

		// Token: 0x04010E0E RID: 69134
		internal static int __PropertyOffset_RuntimeRegistryData;

		// Token: 0x04010E0F RID: 69135
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FRegisterRuntimeData> _RuntimeRegistryData;

		// Token: 0x04010E10 RID: 69136
		internal static int __PropertyOffset_Components;

		// Token: 0x04010E11 RID: 69137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Components;

		// Token: 0x04010E12 RID: 69138
		internal static int __PropertyOffset_MissingComponents;

		// Token: 0x04010E13 RID: 69139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _MissingComponents;
	}
}
