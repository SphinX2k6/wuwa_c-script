using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECC RID: 7884
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroStateMachineBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE8F RID: 122511 RVA: 0x002C3CA7 File Offset: 0x002C1EA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineBase._ClassPtr;
		}

		// Token: 0x0601DE90 RID: 122512 RVA: 0x002C3CB4 File Offset: 0x002C1EB4
		public UKuroStateMachineBase() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE91 RID: 122513 RVA: 0x002C3CDC File Offset: 0x002C1EDC
		public UKuroStateMachineBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077B5 RID: 30645
		// (get) Token: 0x0601DE92 RID: 122514 RVA: 0x002C3D0F File Offset: 0x002C1F0F
		// (set) Token: 0x0601DE93 RID: 122515 RVA: 0x002C3D23 File Offset: 0x002C1F23
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroStateMachineBase.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroStateMachineBase.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170077B6 RID: 30646
		// (get) Token: 0x0601DE94 RID: 122516 RVA: 0x002C3D38 File Offset: 0x002C1F38
		// (set) Token: 0x0601DE95 RID: 122517 RVA: 0x002C3D71 File Offset: 0x002C1F71
		public TMap<string, UKuroStateMachineConditionBase> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UKuroStateMachineConditionBase> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TMap<string, UKuroStateMachineConditionBase>(base.NativePtr + (IntPtr)UKuroStateMachineBase.__PropertyOffset_Transitions, this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x170077B7 RID: 30647
		// (get) Token: 0x0601DE96 RID: 122518 RVA: 0x002C3D80 File Offset: 0x002C1F80
		// (set) Token: 0x0601DE97 RID: 122519 RVA: 0x002C3DB9 File Offset: 0x002C1FB9
		public TArray<UKuroStateMachineBase> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroStateMachineBase> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<UKuroStateMachineBase>(base.NativePtr + (IntPtr)UKuroStateMachineBase.__PropertyOffset_Children, this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x0601DE98 RID: 122520 RVA: 0x002C3DC7 File Offset: 0x002C1FC7
		static UKuroStateMachineBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineBase");
		}

		// Token: 0x0601DE99 RID: 122521 RVA: 0x002C3DD5 File Offset: 0x002C1FD5
		protected UKuroStateMachineBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010318 RID: 66328
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineBase";

		// Token: 0x04010319 RID: 66329
		private static IntPtr _ClassPtr;

		// Token: 0x0401031A RID: 66330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401031B RID: 66331
		internal static int __PropertyOffset_Name;

		// Token: 0x0401031C RID: 66332
		internal static int __PropertyOffset_Transitions;

		// Token: 0x0401031D RID: 66333
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroStateMachineConditionBase> _Transitions;

		// Token: 0x0401031E RID: 66334
		internal static int __PropertyOffset_Children;

		// Token: 0x0401031F RID: 66335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroStateMachineBase> _Children;
	}
}
