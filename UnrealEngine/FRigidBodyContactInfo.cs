using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001096 RID: 4246
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RigidBodyContactInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigidBodyContactInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F296 RID: 62102 RVA: 0x00167ECD File Offset: 0x001660CD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigidBodyContactInfo._ScriptStructPtr != 0) ? FRigidBodyContactInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RigidBodyContactInfo", ref FRigidBodyContactInfo._ScriptStructPtr);
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600F297 RID: 62103 RVA: 0x00167EF1 File Offset: 0x001660F1
		// (set) Token: 0x0600F298 RID: 62104 RVA: 0x00167F05 File Offset: 0x00166105
		public unsafe FVector ContactPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactPosition) = value;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600F299 RID: 62105 RVA: 0x00167F1A File Offset: 0x0016611A
		// (set) Token: 0x0600F29A RID: 62106 RVA: 0x00167F2E File Offset: 0x0016612E
		public unsafe FVector ContactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactNormal) = value;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600F29B RID: 62107 RVA: 0x00167F43 File Offset: 0x00166143
		// (set) Token: 0x0600F29C RID: 62108 RVA: 0x00167F53 File Offset: 0x00166153
		public unsafe float ContactPenetration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactPenetration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_ContactPenetration) = value;
			}
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600F29D RID: 62109 RVA: 0x00167F64 File Offset: 0x00166164
		// (set) Token: 0x0600F29E RID: 62110 RVA: 0x00167FA8 File Offset: 0x001661A8
		public TFixedArray<UPhysicalMaterial> PhysMaterial
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UPhysicalMaterial> result;
				if ((result = this._PhysMaterial) == null)
				{
					result = (this._PhysMaterial = new TFixedArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)FRigidBodyContactInfo.__PropertyOffset_PhysMaterial, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PhysMaterial.CopyAssign(value);
			}
		}

		// Token: 0x0600F29F RID: 62111 RVA: 0x00167FB6 File Offset: 0x001661B6
		public FRigidBodyContactInfo()
		{
		}

		// Token: 0x0600F2A0 RID: 62112 RVA: 0x00167FBE File Offset: 0x001661BE
		public FRigidBodyContactInfo(FVector ContactPosition, FVector ContactNormal, float ContactPenetration, TFixedArray<UPhysicalMaterial> PhysMaterial)
		{
			this.ContactPosition = ContactPosition;
			this.ContactNormal = ContactNormal;
			this.ContactPenetration = ContactPenetration;
			this.PhysMaterial = PhysMaterial;
		}

		// Token: 0x0600F2A1 RID: 62113 RVA: 0x00167FE3 File Offset: 0x001661E3
		protected override IntPtr GetUStructPtr()
		{
			return FRigidBodyContactInfo.StaticStruct();
		}

		// Token: 0x0600F2A2 RID: 62114 RVA: 0x00167FEF File Offset: 0x001661EF
		[NullableContext(2)]
		public FRigidBodyContactInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F2A3 RID: 62115 RVA: 0x00167FF9 File Offset: 0x001661F9
		public FRigidBodyContactInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F2A4 RID: 62116 RVA: 0x00168004 File Offset: 0x00166204
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigidBodyContactInfo(Pointer, false, true);
		}

		// Token: 0x0600F2A5 RID: 62117 RVA: 0x0016800E File Offset: 0x0016620E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigidBodyContactInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400839F RID: 33695
		public const string __ObjectPath = "/Script/Engine.RigidBodyContactInfo";

		// Token: 0x040083A0 RID: 33696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083A1 RID: 33697
		internal static int __PropertyOffset_ContactPosition;

		// Token: 0x040083A2 RID: 33698
		internal static int __PropertyOffset_ContactNormal;

		// Token: 0x040083A3 RID: 33699
		internal static int __PropertyOffset_ContactPenetration;

		// Token: 0x040083A4 RID: 33700
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x040083A5 RID: 33701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UPhysicalMaterial> _PhysMaterial;
	}
}
