using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018BF RID: 6335
	[UnrealObjectPath("/Script/KuroGameplay.KuroAttachLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAttachLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017693 RID: 95891 RVA: 0x00223B2E File Offset: 0x00221D2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAttachLibrary._ClassPtr;
		}

		// Token: 0x06017694 RID: 95892 RVA: 0x00223B3C File Offset: 0x00221D3C
		public UKuroAttachLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAttachLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017695 RID: 95893 RVA: 0x00223B64 File Offset: 0x00221D64
		[NullableContext(1)]
		public UKuroAttachLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAttachLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017696 RID: 95894 RVA: 0x00223B98 File Offset: 0x00221D98
		[NullableContext(2)]
		public unsafe static bool KuroAttachToComponentWithLocationAxisFilter(AActor Child, USceneComponent ParentComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAttachLibrary.__KuroAttachToComponentWithLocationAxisFilter_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero, (ParentComponent != null) ? ParentComponent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bIgnoreTargetLocationX, bIgnoreTargetLocationY, bIgnoreTargetLocationZ);
			}
		}

		// Token: 0x06017697 RID: 95895 RVA: 0x00223BE0 File Offset: 0x00221DE0
		[NullableContext(2)]
		public unsafe static bool KuroAttachToActorWithLocationAxisFilter(AActor Child, AActor Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAttachLibrary.__KuroAttachToActorWithLocationAxisFilter_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies, bIgnoreTargetLocationX, bIgnoreTargetLocationY, bIgnoreTargetLocationZ);
			}
		}

		// Token: 0x06017698 RID: 95896 RVA: 0x00223C25 File Offset: 0x00221E25
		[NullableContext(2)]
		public static void ClearKuroLocationAxisFilteredAttach(AActor Child)
		{
			UKuroAttachLibrary.__ClearKuroLocationAxisFilteredAttach_Internal((Child != null) ? Child.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017699 RID: 95897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroAttachToComponentWithLocationAxisFilter_Internal(IntPtr Child, IntPtr ParentComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ);

		// Token: 0x0601769A RID: 95898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroAttachToActorWithLocationAxisFilter_Internal(IntPtr Child, IntPtr Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies, bool bIgnoreTargetLocationX, bool bIgnoreTargetLocationY, bool bIgnoreTargetLocationZ);

		// Token: 0x0601769B RID: 95899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKuroLocationAxisFilteredAttach_Internal(IntPtr Child);

		// Token: 0x0601769C RID: 95900 RVA: 0x00223C3C File Offset: 0x00221E3C
		static UKuroAttachLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroAttachLibrary");
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x00223C4A File Offset: 0x00221E4A
		protected UKuroAttachLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBBA RID: 52154
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroAttachLibrary";

		// Token: 0x0400CBBB RID: 52155
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBBC RID: 52156
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
