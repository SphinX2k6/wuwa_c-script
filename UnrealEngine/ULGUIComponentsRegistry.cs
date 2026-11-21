using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000673 RID: 1651
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIComponentsRegistry")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class ULGUIComponentsRegistry : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008FF3 RID: 36851 RVA: 0x000D7DF2 File Offset: 0x000D5FF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIComponentsRegistry._ClassPtr;
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x000D7E00 File Offset: 0x000D6000
		public ULGUIComponentsRegistry() : this(BuiltinUtils.AllocNativeUObject(ULGUIComponentsRegistry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x000D7E28 File Offset: 0x000D6028
		public ULGUIComponentsRegistry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIComponentsRegistry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x000D7E5B File Offset: 0x000D605B
		// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x000D7E6F File Offset: 0x000D606F
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

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x000D7E84 File Offset: 0x000D6084
		// (set) Token: 0x06008FF9 RID: 36857 RVA: 0x000D7EBD File Offset: 0x000D60BD
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

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x000D7ECC File Offset: 0x000D60CC
		// (set) Token: 0x06008FFB RID: 36859 RVA: 0x000D7F05 File Offset: 0x000D6105
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

		// Token: 0x06008FFC RID: 36860 RVA: 0x000D7F13 File Offset: 0x000D6113
		public void SetComponents([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> NewComponents)
		{
			ULGUIComponentsRegistry.__SetComponents_Internal(base.NativePtr, (NewComponents ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x000D7F30 File Offset: 0x000D6130
		public TArray<AActor> GetComponents()
		{
			return new TArray<AActor>(ULGUIComponentsRegistry.__GetComponents_Internal(base.NativePtr), null);
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x000D7F43 File Offset: 0x000D6143
		[NullableContext(2)]
		public void CopyFrom(ULGUIComponentsRegistry Other)
		{
			ULGUIComponentsRegistry.__CopyFrom_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008FFF RID: 36863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetComponents_Internal(IntPtr @this, IntPtr NewComponents);

		// Token: 0x06009000 RID: 36864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponents_Internal(IntPtr @this);

		// Token: 0x06009001 RID: 36865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyFrom_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06009002 RID: 36866 RVA: 0x000D7F60 File Offset: 0x000D6160
		static ULGUIComponentsRegistry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIComponentsRegistry");
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x000D7F6E File Offset: 0x000D616E
		protected ULGUIComponentsRegistry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003EEE RID: 16110
		public new const string __ObjectPath = "/Script/LGUI.LGUIComponentsRegistry";

		// Token: 0x04003EEF RID: 16111
		private static IntPtr _ClassPtr;

		// Token: 0x04003EF0 RID: 16112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003EF1 RID: 16113
		internal static int __PropertyOffset_TsClassName;

		// Token: 0x04003EF2 RID: 16114
		internal static int __PropertyOffset_Components;

		// Token: 0x04003EF3 RID: 16115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Components;

		// Token: 0x04003EF4 RID: 16116
		internal static int __PropertyOffset_MissingComponents;

		// Token: 0x04003EF5 RID: 16117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _MissingComponents;
	}
}
