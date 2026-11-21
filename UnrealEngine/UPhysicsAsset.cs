using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025C RID: 604
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsAsset")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UPhysicsAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033A8 RID: 13224 RVA: 0x00049D65 File Offset: 0x00047F65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsAsset._ClassPtr;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00049D74 File Offset: 0x00047F74
		public UPhysicsAsset() : this(BuiltinUtils.AllocNativeUObject(UPhysicsAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00049D9C File Offset: 0x00047F9C
		public UPhysicsAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x00049DD0 File Offset: 0x00047FD0
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x00049E09 File Offset: 0x00048009
		public TArray<int> BoundsBodies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BoundsBodies) == null)
				{
					result = (this._BoundsBodies = new TArray<int>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_BoundsBodies, this));
				}
				return result;
			}
			set
			{
				this.BoundsBodies.CopyAssign(value);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x00049E17 File Offset: 0x00048017
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00049E30 File Offset: 0x00048030
		public unsafe bool bNotForDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) & UPhysicsAsset.__PropertyMask_bNotForDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) = ((*(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_bNotForDedicatedServer) & ~UPhysicsAsset.__PropertyMask_bNotForDedicatedServer) | (value ? UPhysicsAsset.__PropertyMask_bNotForDedicatedServer : 0));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x00049E60 File Offset: 0x00048060
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x00049E99 File Offset: 0x00048099
		public TArray<UBodySetup> BodySetup_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._BodySetup_DEPRECATED) == null)
				{
					result = (this._BodySetup_DEPRECATED = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UPhysicsAsset.__PropertyOffset_BodySetup_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.BodySetup_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00049EA7 File Offset: 0x000480A7
		static UPhysicsAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsAsset");
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00049EB5 File Offset: 0x000480B5
		protected UPhysicsAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011F1 RID: 4593
		public new const string __ObjectPath = "/Script/Engine.PhysicsAsset";

		// Token: 0x040011F2 RID: 4594
		private static IntPtr _ClassPtr;

		// Token: 0x040011F3 RID: 4595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040011F4 RID: 4596
		internal static int __PropertyOffset_BoundsBodies;

		// Token: 0x040011F5 RID: 4597
		[Nullable(2)]
		private TArray<int> _BoundsBodies;

		// Token: 0x040011F6 RID: 4598
		internal static int __PropertyOffset_bNotForDedicatedServer;

		// Token: 0x040011F7 RID: 4599
		internal static byte __PropertyMask_bNotForDedicatedServer;

		// Token: 0x040011F8 RID: 4600
		internal static int __PropertyOffset_BodySetup_DEPRECATED;

		// Token: 0x040011F9 RID: 4601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _BodySetup_DEPRECATED;
	}
}
