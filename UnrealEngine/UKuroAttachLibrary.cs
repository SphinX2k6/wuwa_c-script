using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003DC RID: 988
	[UnrealObjectPath("/Script/KuroGameplay.KuroAttachLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAttachLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006121 RID: 24865 RVA: 0x0008AC8E File Offset: 0x00088E8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAttachLibrary._ClassPtr;
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x0008AC9C File Offset: 0x00088E9C
		public UKuroAttachLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAttachLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x0008ACC4 File Offset: 0x00088EC4
		[NullableContext(1)]
		public UKuroAttachLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAttachLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x0008ACF8 File Offset: 0x00088EF8
		[NullableContext(2)]
		public unsafe static bool KuroAttachToComponentWithLocationAxisFilter(AActor Child, USceneComponent ParentComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAttachLibrary.__KuroAttachToComponentWithLocationAxisFilter_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero, (ParentComponent != null) ? ParentComponent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bIgnoreTargetLocationX, bIgnoreTargetLocationY, bIgnoreTargetLocationZ);
			}
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x0008AD40 File Offset: 0x00088F40
		[NullableContext(2)]
		public unsafe static bool KuroAttachToActorWithLocationAxisFilter(AActor Child, AActor Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAttachLibrary.__KuroAttachToActorWithLocationAxisFilter_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bIgnoreTargetLocationX, bIgnoreTargetLocationY, bIgnoreTargetLocationZ);
			}
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x0008AD85 File Offset: 0x00088F85
		[NullableContext(2)]
		public static void ClearKuroLocationAxisFilteredAttach(AActor Child)
		{
			UKuroAttachLibrary.__ClearKuroLocationAxisFilteredAttach_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006127 RID: 24871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroAttachToComponentWithLocationAxisFilter_Internal(IntPtr Child, IntPtr ParentComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ);

		// Token: 0x06006128 RID: 24872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroAttachToActorWithLocationAxisFilter_Internal(IntPtr Child, IntPtr Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ);

		// Token: 0x06006129 RID: 24873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKuroLocationAxisFilteredAttach_Internal(IntPtr Child);

		// Token: 0x0600612A RID: 24874 RVA: 0x0008AD9C File Offset: 0x00088F9C
		static UKuroAttachLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAttachLibrary");
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x0008ADAA File Offset: 0x00088FAA
		protected UKuroAttachLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002963 RID: 10595
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAttachLibrary";

		// Token: 0x04002964 RID: 10596
		private static IntPtr _ClassPtr;

		// Token: 0x04002965 RID: 10597
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
