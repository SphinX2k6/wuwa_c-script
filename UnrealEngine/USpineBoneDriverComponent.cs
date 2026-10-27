using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028AD RID: 10413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineBoneDriverComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class USpineBoneDriverComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060269B1 RID: 158129 RVA: 0x003AEA69 File Offset: 0x003ACC69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineBoneDriverComponent._ClassPtr;
		}

		// Token: 0x060269B2 RID: 158130 RVA: 0x003AEA78 File Offset: 0x003ACC78
		public USpineBoneDriverComponent() : this(BuiltinUtils.AllocNativeUObject(USpineBoneDriverComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060269B3 RID: 158131 RVA: 0x003AEAA0 File Offset: 0x003ACCA0
		public USpineBoneDriverComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineBoneDriverComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094CF RID: 38095
		// (get) Token: 0x060269B4 RID: 158132 RVA: 0x003AEAD3 File Offset: 0x003ACCD3
		// (set) Token: 0x060269B5 RID: 158133 RVA: 0x003AEAE7 File Offset: 0x003ACCE7
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + USpineBoneDriverComponent.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USpineBoneDriverComponent.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170094D0 RID: 38096
		// (get) Token: 0x060269B6 RID: 158134 RVA: 0x003AEAFC File Offset: 0x003ACCFC
		// (set) Token: 0x060269B7 RID: 158135 RVA: 0x003AEB10 File Offset: 0x003ACD10
		public unsafe string BoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineBoneDriverComponent.__PropertyOffset_BoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineBoneDriverComponent.__PropertyOffset_BoneName)), value);
			}
		}

		// Token: 0x170094D1 RID: 38097
		// (get) Token: 0x060269B8 RID: 158136 RVA: 0x003AEB25 File Offset: 0x003ACD25
		// (set) Token: 0x060269B9 RID: 158137 RVA: 0x003AEB35 File Offset: 0x003ACD35
		public unsafe bool UseComponentTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseComponentTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseComponentTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094D2 RID: 38098
		// (get) Token: 0x060269BA RID: 158138 RVA: 0x003AEB46 File Offset: 0x003ACD46
		// (set) Token: 0x060269BB RID: 158139 RVA: 0x003AEB56 File Offset: 0x003ACD56
		public unsafe bool UsePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UsePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UsePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094D3 RID: 38099
		// (get) Token: 0x060269BC RID: 158140 RVA: 0x003AEB67 File Offset: 0x003ACD67
		// (set) Token: 0x060269BD RID: 158141 RVA: 0x003AEB77 File Offset: 0x003ACD77
		public unsafe bool UseRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170094D4 RID: 38100
		// (get) Token: 0x060269BE RID: 158142 RVA: 0x003AEB88 File Offset: 0x003ACD88
		// (set) Token: 0x060269BF RID: 158143 RVA: 0x003AEB98 File Offset: 0x003ACD98
		public unsafe bool UseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineBoneDriverComponent.__PropertyOffset_UseScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x060269C0 RID: 158144 RVA: 0x003AEBA9 File Offset: 0x003ACDA9
		[NullableContext(2)]
		public void BeforeUpdateWorldTransform(USpineSkeletonComponent skeleton)
		{
			USpineBoneDriverComponent.__BeforeUpdateWorldTransform_Internal(base.NativePtr, (skeleton != null) ? skeleton.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060269C1 RID: 158145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeforeUpdateWorldTransform_Internal(IntPtr @this, IntPtr skeleton);

		// Token: 0x060269C2 RID: 158146 RVA: 0x003AEBC6 File Offset: 0x003ACDC6
		static USpineBoneDriverComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineBoneDriverComponent");
		}

		// Token: 0x060269C3 RID: 158147 RVA: 0x003AEBD4 File Offset: 0x003ACDD4
		protected USpineBoneDriverComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015342 RID: 86850
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineBoneDriverComponent";

		// Token: 0x04015343 RID: 86851
		private static IntPtr _ClassPtr;

		// Token: 0x04015344 RID: 86852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015345 RID: 86853
		internal static int __PropertyOffset_Target;

		// Token: 0x04015346 RID: 86854
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04015347 RID: 86855
		internal static int __PropertyOffset_UseComponentTransform;

		// Token: 0x04015348 RID: 86856
		internal static int __PropertyOffset_UsePosition;

		// Token: 0x04015349 RID: 86857
		internal static int __PropertyOffset_UseRotation;

		// Token: 0x0401534A RID: 86858
		internal static int __PropertyOffset_UseScale;
	}
}
