using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BB RID: 1211
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigComponent")]
	[UnrealStructLayout(1808, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class UControlRigComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600407F RID: 16511 RVA: 0x00060EFE File Offset: 0x0005F0FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigComponent._ClassPtr;
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x00060F0C File Offset: 0x0005F10C
		public UControlRigComponent() : this(BuiltinUtils.AllocNativeUObject(UControlRigComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x00060F34 File Offset: 0x0005F134
		[NullableContext(1)]
		public UControlRigComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x00060F67 File Offset: 0x0005F167
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x00060F7B File Offset: 0x0005F17B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UControlRig> ControlRigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_ControlRigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_ControlRigClass) = value;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x00060F90 File Offset: 0x0005F190
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x00060FC9 File Offset: 0x0005F1C9
		[Nullable(1)]
		public FControlRigComponentDelegate OnPostInitializeDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FControlRigComponentDelegate result;
				if ((result = this._OnPostInitializeDelegate) == null)
				{
					result = (this._OnPostInitializeDelegate = new FControlRigComponentDelegate(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostInitializeDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostInitializeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x00060FEC File Offset: 0x0005F1EC
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x00061025 File Offset: 0x0005F225
		[Nullable(1)]
		public FControlRigComponentDelegate OnPreSetupDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FControlRigComponentDelegate result;
				if ((result = this._OnPreSetupDelegate) == null)
				{
					result = (this._OnPreSetupDelegate = new FControlRigComponentDelegate(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPreSetupDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPreSetupDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x00061048 File Offset: 0x0005F248
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x00061081 File Offset: 0x0005F281
		[Nullable(1)]
		public FControlRigComponentDelegate OnPostSetupDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FControlRigComponentDelegate result;
				if ((result = this._OnPostSetupDelegate) == null)
				{
					result = (this._OnPostSetupDelegate = new FControlRigComponentDelegate(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostSetupDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostSetupDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x000610A4 File Offset: 0x0005F2A4
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x000610DD File Offset: 0x0005F2DD
		[Nullable(1)]
		public FControlRigComponentDelegate OnPreUpdateDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FControlRigComponentDelegate result;
				if ((result = this._OnPreUpdateDelegate) == null)
				{
					result = (this._OnPreUpdateDelegate = new FControlRigComponentDelegate(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPreUpdateDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPreUpdateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x00061100 File Offset: 0x0005F300
		// (set) Token: 0x0600408D RID: 16525 RVA: 0x00061139 File Offset: 0x0005F339
		[Nullable(1)]
		public FControlRigComponentDelegate OnPostUpdateDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FControlRigComponentDelegate result;
				if ((result = this._OnPostUpdateDelegate) == null)
				{
					result = (this._OnPostUpdateDelegate = new FControlRigComponentDelegate(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostUpdateDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_OnPostUpdateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x0006115C File Offset: 0x0005F35C
		// (set) Token: 0x0600408F RID: 16527 RVA: 0x00061195 File Offset: 0x0005F395
		[Nullable(1)]
		public TArray<FControlRigComponentMappedElement> MappedElements
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FControlRigComponentMappedElement> result;
				if ((result = this._MappedElements) == null)
				{
					result = (this._MappedElements = new TArray<FControlRigComponentMappedElement>(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_MappedElements, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MappedElements.CopyAssign(value);
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x000611A3 File Offset: 0x0005F3A3
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x000611B3 File Offset: 0x0005F3B3
		public unsafe bool bResetTransformBeforeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bResetTransformBeforeTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bResetTransformBeforeTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x000611C4 File Offset: 0x0005F3C4
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x000611D4 File Offset: 0x0005F3D4
		public unsafe bool bResetInitialsBeforeSetup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bResetInitialsBeforeSetup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bResetInitialsBeforeSetup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x000611E5 File Offset: 0x0005F3E5
		// (set) Token: 0x06004095 RID: 16533 RVA: 0x000611F5 File Offset: 0x0005F3F5
		public unsafe bool bUpdateRigOnTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bUpdateRigOnTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bUpdateRigOnTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x00061206 File Offset: 0x0005F406
		// (set) Token: 0x06004097 RID: 16535 RVA: 0x00061216 File Offset: 0x0005F416
		public unsafe bool bUpdateInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bUpdateInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bUpdateInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x00061227 File Offset: 0x0005F427
		// (set) Token: 0x06004099 RID: 16537 RVA: 0x00061237 File Offset: 0x0005F437
		public unsafe bool bDrawBones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bDrawBones) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigComponent.__PropertyOffset_bDrawBones) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600409A RID: 16538 RVA: 0x00061248 File Offset: 0x0005F448
		// (set) Token: 0x0600409B RID: 16539 RVA: 0x0006125C File Offset: 0x0005F45C
		public unsafe UControlRig ControlRig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + UControlRigComponent.__PropertyOffset_ControlRig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UControlRigComponent.__PropertyOffset_ControlRig, value);
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00061271 File Offset: 0x0005F471
		public void Update(float DeltaTime = 0f)
		{
			UControlRigComponent.__Update_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0006127F File Offset: 0x0005F47F
		public void SetMappedElements([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FControlRigComponentMappedElement> NewMappedElements)
		{
			UControlRigComponent.__SetMappedElements_Internal(base.NativePtr, (NewMappedElements ?? new TArray<FControlRigComponentMappedElement>()).NativePtr);
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0006129C File Offset: 0x0005F49C
		public unsafe void SetInitialSpaceTransform(FName SpaceName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InitialTransform;
			UControlRigComponent.__SetInitialSpaceTransform_Internal(base.NativePtr, SpaceName, ptr, Space);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x000612D0 File Offset: 0x0005F4D0
		public unsafe void SetInitialBoneTransform(FName BoneName, FTransform InitialTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, bool bPropagateToChildren = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InitialTransform;
			UControlRigComponent.__SetInitialBoneTransform_Internal(base.NativePtr, BoneName, ptr, Space, bPropagateToChildren);
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00061304 File Offset: 0x0005F504
		public void SetControlVector2D(FName ControlName, FVector2D Value)
		{
			UControlRigComponent.__SetControlVector2D_Internal(base.NativePtr, ControlName, Value);
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00061314 File Offset: 0x0005F514
		public unsafe void SetControlTransform(FName ControlName, FTransform Value, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Value;
			UControlRigComponent.__SetControlTransform_Internal(base.NativePtr, ControlName, ptr, Space);
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00061346 File Offset: 0x0005F546
		public void SetControlScale(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			UControlRigComponent.__SetControlScale_Internal(base.NativePtr, ControlName, Value, Space);
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00061356 File Offset: 0x0005F556
		public void SetControlRotator(FName ControlName, FRotator Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			UControlRigComponent.__SetControlRotator_Internal(base.NativePtr, ControlName, Value, Space);
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00061366 File Offset: 0x0005F566
		public void SetControlPosition(FName ControlName, FVector Value, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			UControlRigComponent.__SetControlPosition_Internal(base.NativePtr, ControlName, Value, Space);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00061378 File Offset: 0x0005F578
		public unsafe void SetControlOffset(FName ControlName, FTransform OffsetTransform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OffsetTransform;
			UControlRigComponent.__SetControlOffset_Internal(base.NativePtr, ControlName, ptr, Space);
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x000613AA File Offset: 0x0005F5AA
		public void SetControlInt(FName ControlName, int Value)
		{
			UControlRigComponent.__SetControlInt_Internal(base.NativePtr, ControlName, Value);
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x000613B9 File Offset: 0x0005F5B9
		public void SetControlFloat(FName ControlName, float Value)
		{
			UControlRigComponent.__SetControlFloat_Internal(base.NativePtr, ControlName, Value);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x000613C8 File Offset: 0x0005F5C8
		public void SetControlBool(FName ControlName, bool Value)
		{
			UControlRigComponent.__SetControlBool_Internal(base.NativePtr, ControlName, Value);
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000613D8 File Offset: 0x0005F5D8
		public unsafe void SetBoneTransform(FName BoneName, FTransform Transform, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace, float Weight = 1f, bool bPropagateToChildren = true)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UControlRigComponent.__SetBoneTransform_Internal(base.NativePtr, BoneName, ptr, Space, Weight, bPropagateToChildren);
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0006140E File Offset: 0x0005F60E
		public void SetBoneInitialTransformsFromSkeletalMesh(USkeletalMesh InSkeletalMesh)
		{
			UControlRigComponent.__SetBoneInitialTransformsFromSkeletalMesh_Internal(base.NativePtr, (InSkeletalMesh != null) ? InSkeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x0006142B File Offset: 0x0005F62B
		public virtual void OnPreUpdate(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPreUpdate_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00061448 File Offset: 0x0005F648
		protected virtual void OnPreUpdate_Implementation(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPreUpdate_Implementation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x00061465 File Offset: 0x0005F665
		public virtual void OnPreSetup(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPreSetup_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00061482 File Offset: 0x0005F682
		protected virtual void OnPreSetup_Implementation(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPreSetup_Implementation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x0006149F File Offset: 0x0005F69F
		public virtual void OnPostUpdate(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostUpdate_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000614BC File Offset: 0x0005F6BC
		protected virtual void OnPostUpdate_Implementation(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostUpdate_Implementation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000614D9 File Offset: 0x0005F6D9
		public virtual void OnPostSetup(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostSetup_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x000614F6 File Offset: 0x0005F6F6
		protected virtual void OnPostSetup_Implementation(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostSetup_Implementation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00061513 File Offset: 0x0005F713
		public virtual void OnPostInitialize(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostInitialize_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00061530 File Offset: 0x0005F730
		protected virtual void OnPostInitialize_Implementation(UControlRigComponent Component)
		{
			UControlRigComponent.__OnPostInitialize_Implementation_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0006154D File Offset: 0x0005F74D
		public void Initialize()
		{
			UControlRigComponent.__Initialize_Internal(base.NativePtr);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0006155A File Offset: 0x0005F75A
		public FTransform GetSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetSpaceTransform_Internal(base.NativePtr, SpaceName, Space);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00061569 File Offset: 0x0005F769
		public FTransform GetInitialSpaceTransform(FName SpaceName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetInitialSpaceTransform_Internal(base.NativePtr, SpaceName, Space);
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00061578 File Offset: 0x0005F778
		public FTransform GetInitialBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetInitialBoneTransform_Internal(base.NativePtr, BoneName, Space);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00061587 File Offset: 0x0005F787
		[NullableContext(1)]
		public TArray<FName> GetElementNames(ERigElementType ElementType = ERigElementType.Bone)
		{
			return new TArray<FName>(UControlRigComponent.__GetElementNames_Internal(base.NativePtr, ElementType), null);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0006159B File Offset: 0x0005F79B
		public FVector2D GetControlVector2D(FName ControlName)
		{
			return UControlRigComponent.__GetControlVector2D_Internal(base.NativePtr, ControlName);
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x000615A9 File Offset: 0x0005F7A9
		public FTransform GetControlTransform(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetControlTransform_Internal(base.NativePtr, ControlName, Space);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x000615B8 File Offset: 0x0005F7B8
		public FVector GetControlScale(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			return UControlRigComponent.__GetControlScale_Internal(base.NativePtr, ControlName, Space);
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x000615C7 File Offset: 0x0005F7C7
		public FRotator GetControlRotator(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			return UControlRigComponent.__GetControlRotator_Internal(base.NativePtr, ControlName, Space);
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x000615D6 File Offset: 0x0005F7D6
		public UControlRig GetControlRig()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UControlRig>(UControlRigComponent.__GetControlRig_Internal(base.NativePtr));
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x000615E8 File Offset: 0x0005F7E8
		public FVector GetControlPosition(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.LocalSpace)
		{
			return UControlRigComponent.__GetControlPosition_Internal(base.NativePtr, ControlName, Space);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x000615F7 File Offset: 0x0005F7F7
		public FTransform GetControlOffset(FName ControlName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetControlOffset_Internal(base.NativePtr, ControlName, Space);
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00061606 File Offset: 0x0005F806
		public int GetControlInt(FName ControlName)
		{
			return UControlRigComponent.__GetControlInt_Internal(base.NativePtr, ControlName);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00061614 File Offset: 0x0005F814
		public float GetControlFloat(FName ControlName)
		{
			return UControlRigComponent.__GetControlFloat_Internal(base.NativePtr, ControlName);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00061622 File Offset: 0x0005F822
		public bool GetControlBool(FName ControlName)
		{
			return UControlRigComponent.__GetControlBool_Internal(base.NativePtr, ControlName);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00061630 File Offset: 0x0005F830
		public FTransform GetBoneTransform(FName BoneName, EControlRigComponentSpace Space = EControlRigComponentSpace.RigSpace)
		{
			return UControlRigComponent.__GetBoneTransform_Internal(base.NativePtr, BoneName, Space);
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x0006163F File Offset: 0x0005F83F
		public float GetAbsoluteTime()
		{
			return UControlRigComponent.__GetAbsoluteTime_Internal(base.NativePtr);
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x0006164C File Offset: 0x0005F84C
		public bool DoesElementExist(FName Name, ERigElementType ElementType = ERigElementType.Bone)
		{
			return UControlRigComponent.__DoesElementExist_Internal(base.NativePtr, Name, ElementType);
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x0006165B File Offset: 0x0005F85B
		public void ClearMappedElements()
		{
			UControlRigComponent.__ClearMappedElements_Internal(base.NativePtr);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00061668 File Offset: 0x0005F868
		public void AddMappedSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FControlRigComponentMappedBone> Bones, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FControlRigComponentMappedCurve> Curves)
		{
			UControlRigComponent.__AddMappedSkeletalMesh_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero, (Bones ?? new TArray<FControlRigComponentMappedBone>()).NativePtr, (Curves ?? new TArray<FControlRigComponentMappedCurve>()).NativePtr);
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x000616A3 File Offset: 0x0005F8A3
		public void AddMappedElements([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FControlRigComponentMappedElement> NewMappedElements)
		{
			UControlRigComponent.__AddMappedElements_Internal(base.NativePtr, (NewMappedElements ?? new TArray<FControlRigComponentMappedElement>()).NativePtr);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x000616BF File Offset: 0x0005F8BF
		public void AddMappedComponents([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FControlRigComponentMappedComponent> Components)
		{
			UControlRigComponent.__AddMappedComponents_Internal(base.NativePtr, (Components ?? new TArray<FControlRigComponentMappedComponent>()).NativePtr);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000616DB File Offset: 0x0005F8DB
		public void AddMappedCompleteSkeletalMesh(USkeletalMeshComponent SkeletalMeshComponent)
		{
			UControlRigComponent.__AddMappedCompleteSkeletalMesh_Internal(base.NativePtr, (SkeletalMeshComponent != null) ? SkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060040CC RID: 16588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x060040CD RID: 16589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMappedElements_Internal(IntPtr @this, IntPtr NewMappedElements);

		// Token: 0x060040CE RID: 16590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitialSpaceTransform_Internal(IntPtr @this, FName SpaceName, in FTransform InitialTransform, EControlRigComponentSpace Space);

		// Token: 0x060040CF RID: 16591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitialBoneTransform_Internal(IntPtr @this, FName BoneName, in FTransform InitialTransform, EControlRigComponentSpace Space, bool bPropagateToChildren);

		// Token: 0x060040D0 RID: 16592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlVector2D_Internal(IntPtr @this, FName ControlName, FVector2D Value);

		// Token: 0x060040D1 RID: 16593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlTransform_Internal(IntPtr @this, FName ControlName, in FTransform Value, EControlRigComponentSpace Space);

		// Token: 0x060040D2 RID: 16594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlScale_Internal(IntPtr @this, FName ControlName, FVector Value, EControlRigComponentSpace Space);

		// Token: 0x060040D3 RID: 16595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlRotator_Internal(IntPtr @this, FName ControlName, FRotator Value, EControlRigComponentSpace Space);

		// Token: 0x060040D4 RID: 16596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlPosition_Internal(IntPtr @this, FName ControlName, FVector Value, EControlRigComponentSpace Space);

		// Token: 0x060040D5 RID: 16597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlOffset_Internal(IntPtr @this, FName ControlName, in FTransform OffsetTransform, EControlRigComponentSpace Space);

		// Token: 0x060040D6 RID: 16598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlInt_Internal(IntPtr @this, FName ControlName, int Value);

		// Token: 0x060040D7 RID: 16599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlFloat_Internal(IntPtr @this, FName ControlName, float Value);

		// Token: 0x060040D8 RID: 16600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlBool_Internal(IntPtr @this, FName ControlName, bool Value);

		// Token: 0x060040D9 RID: 16601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneTransform_Internal(IntPtr @this, FName BoneName, in FTransform Transform, EControlRigComponentSpace Space, float Weight, bool bPropagateToChildren);

		// Token: 0x060040DA RID: 16602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneInitialTransformsFromSkeletalMesh_Internal(IntPtr @this, IntPtr InSkeletalMesh);

		// Token: 0x060040DB RID: 16603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreUpdate_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040DC RID: 16604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreUpdate_Implementation_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040DD RID: 16605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreSetup_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040DE RID: 16606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreSetup_Implementation_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040DF RID: 16607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostUpdate_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E0 RID: 16608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostUpdate_Implementation_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E1 RID: 16609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostSetup_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E2 RID: 16610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostSetup_Implementation_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E3 RID: 16611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostInitialize_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E4 RID: 16612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPostInitialize_Implementation_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060040E5 RID: 16613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this);

		// Token: 0x060040E6 RID: 16614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetSpaceTransform_Internal(IntPtr @this, FName SpaceName, EControlRigComponentSpace Space);

		// Token: 0x060040E7 RID: 16615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetInitialSpaceTransform_Internal(IntPtr @this, FName SpaceName, EControlRigComponentSpace Space);

		// Token: 0x060040E8 RID: 16616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetInitialBoneTransform_Internal(IntPtr @this, FName BoneName, EControlRigComponentSpace Space);

		// Token: 0x060040E9 RID: 16617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetElementNames_Internal(IntPtr @this, ERigElementType ElementType);

		// Token: 0x060040EA RID: 16618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetControlVector2D_Internal(IntPtr @this, FName ControlName);

		// Token: 0x060040EB RID: 16619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetControlTransform_Internal(IntPtr @this, FName ControlName, EControlRigComponentSpace Space);

		// Token: 0x060040EC RID: 16620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetControlScale_Internal(IntPtr @this, FName ControlName, EControlRigComponentSpace Space);

		// Token: 0x060040ED RID: 16621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetControlRotator_Internal(IntPtr @this, FName ControlName, EControlRigComponentSpace Space);

		// Token: 0x060040EE RID: 16622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetControlRig_Internal(IntPtr @this);

		// Token: 0x060040EF RID: 16623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetControlPosition_Internal(IntPtr @this, FName ControlName, EControlRigComponentSpace Space);

		// Token: 0x060040F0 RID: 16624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetControlOffset_Internal(IntPtr @this, FName ControlName, EControlRigComponentSpace Space);

		// Token: 0x060040F1 RID: 16625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetControlInt_Internal(IntPtr @this, FName ControlName);

		// Token: 0x060040F2 RID: 16626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetControlFloat_Internal(IntPtr @this, FName ControlName);

		// Token: 0x060040F3 RID: 16627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControlBool_Internal(IntPtr @this, FName ControlName);

		// Token: 0x060040F4 RID: 16628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBoneTransform_Internal(IntPtr @this, FName BoneName, EControlRigComponentSpace Space);

		// Token: 0x060040F5 RID: 16629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAbsoluteTime_Internal(IntPtr @this);

		// Token: 0x060040F6 RID: 16630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesElementExist_Internal(IntPtr @this, FName Name, ERigElementType ElementType);

		// Token: 0x060040F7 RID: 16631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMappedElements_Internal(IntPtr @this);

		// Token: 0x060040F8 RID: 16632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMappedSkeletalMesh_Internal(IntPtr @this, IntPtr SkeletalMeshComponent, IntPtr Bones, IntPtr Curves);

		// Token: 0x060040F9 RID: 16633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMappedElements_Internal(IntPtr @this, IntPtr NewMappedElements);

		// Token: 0x060040FA RID: 16634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMappedComponents_Internal(IntPtr @this, IntPtr Components);

		// Token: 0x060040FB RID: 16635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMappedCompleteSkeletalMesh_Internal(IntPtr @this, IntPtr SkeletalMeshComponent);

		// Token: 0x060040FC RID: 16636 RVA: 0x000616F8 File Offset: 0x0005F8F8
		static UControlRigComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigComponent");
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00061706 File Offset: 0x0005F906
		protected UControlRigComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001EDC RID: 7900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigComponent";

		// Token: 0x04001EDD RID: 7901
		private static IntPtr _ClassPtr;

		// Token: 0x04001EDE RID: 7902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001EDF RID: 7903
		internal static int __PropertyOffset_ControlRigClass;

		// Token: 0x04001EE0 RID: 7904
		internal static int __PropertyOffset_OnPostInitializeDelegate;

		// Token: 0x04001EE1 RID: 7905
		private FControlRigComponentDelegate _OnPostInitializeDelegate;

		// Token: 0x04001EE2 RID: 7906
		internal static int __PropertyOffset_OnPreSetupDelegate;

		// Token: 0x04001EE3 RID: 7907
		private FControlRigComponentDelegate _OnPreSetupDelegate;

		// Token: 0x04001EE4 RID: 7908
		internal static int __PropertyOffset_OnPostSetupDelegate;

		// Token: 0x04001EE5 RID: 7909
		private FControlRigComponentDelegate _OnPostSetupDelegate;

		// Token: 0x04001EE6 RID: 7910
		internal static int __PropertyOffset_OnPreUpdateDelegate;

		// Token: 0x04001EE7 RID: 7911
		private FControlRigComponentDelegate _OnPreUpdateDelegate;

		// Token: 0x04001EE8 RID: 7912
		internal static int __PropertyOffset_OnPostUpdateDelegate;

		// Token: 0x04001EE9 RID: 7913
		private FControlRigComponentDelegate _OnPostUpdateDelegate;

		// Token: 0x04001EEA RID: 7914
		internal static int __PropertyOffset_MappedElements;

		// Token: 0x04001EEB RID: 7915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FControlRigComponentMappedElement> _MappedElements;

		// Token: 0x04001EEC RID: 7916
		internal static int __PropertyOffset_bResetTransformBeforeTick;

		// Token: 0x04001EED RID: 7917
		internal static int __PropertyOffset_bResetInitialsBeforeSetup;

		// Token: 0x04001EEE RID: 7918
		internal static int __PropertyOffset_bUpdateRigOnTick;

		// Token: 0x04001EEF RID: 7919
		internal static int __PropertyOffset_bUpdateInEditor;

		// Token: 0x04001EF0 RID: 7920
		internal static int __PropertyOffset_bDrawBones;

		// Token: 0x04001EF1 RID: 7921
		internal static int __PropertyOffset_ControlRig;

		// Token: 0x02002C3D RID: 11325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPreUpdate_FunctionParams
		{
			// Token: 0x04016546 RID: 91462
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C3E RID: 11326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPreSetup_FunctionParams
		{
			// Token: 0x04016547 RID: 91463
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C3F RID: 11327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPostUpdate_FunctionParams
		{
			// Token: 0x04016548 RID: 91464
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C40 RID: 11328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPostSetup_FunctionParams
		{
			// Token: 0x04016549 RID: 91465
			[FieldOffset(0)]
			public IntPtr Component;
		}

		// Token: 0x02002C41 RID: 11329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPostInitialize_FunctionParams
		{
			// Token: 0x0401654A RID: 91466
			[FieldOffset(0)]
			public IntPtr Component;
		}
	}
}
