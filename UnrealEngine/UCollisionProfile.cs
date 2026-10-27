using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000944 RID: 2372
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CollisionProfile")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UCollisionProfile : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008615 RID: 34325 RVA: 0x000BF129 File Offset: 0x000BD329
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCollisionProfile._ClassPtr;
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x000BF138 File Offset: 0x000BD338
		public UCollisionProfile() : this(BuiltinUtils.AllocNativeUObject(UCollisionProfile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x000BF160 File Offset: 0x000BD360
		public UCollisionProfile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCollisionProfile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06008618 RID: 34328 RVA: 0x000BF194 File Offset: 0x000BD394
		// (set) Token: 0x06008619 RID: 34329 RVA: 0x000BF1CD File Offset: 0x000BD3CD
		public TArray<FCollisionResponseTemplate> Profiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCollisionResponseTemplate> result;
				if ((result = this._Profiles) == null)
				{
					result = (this._Profiles = new TArray<FCollisionResponseTemplate>(base.NativePtr + (IntPtr)UCollisionProfile.__PropertyOffset_Profiles, this));
				}
				return result;
			}
			set
			{
				this.Profiles.CopyAssign(value);
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x0600861A RID: 34330 RVA: 0x000BF1DC File Offset: 0x000BD3DC
		// (set) Token: 0x0600861B RID: 34331 RVA: 0x000BF215 File Offset: 0x000BD415
		public TArray<FCustomChannelSetup> DefaultChannelResponses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomChannelSetup> result;
				if ((result = this._DefaultChannelResponses) == null)
				{
					result = (this._DefaultChannelResponses = new TArray<FCustomChannelSetup>(base.NativePtr + (IntPtr)UCollisionProfile.__PropertyOffset_DefaultChannelResponses, this));
				}
				return result;
			}
			set
			{
				this.DefaultChannelResponses.CopyAssign(value);
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600861C RID: 34332 RVA: 0x000BF224 File Offset: 0x000BD424
		// (set) Token: 0x0600861D RID: 34333 RVA: 0x000BF25D File Offset: 0x000BD45D
		public TArray<FCustomProfile> EditProfiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomProfile> result;
				if ((result = this._EditProfiles) == null)
				{
					result = (this._EditProfiles = new TArray<FCustomProfile>(base.NativePtr + (IntPtr)UCollisionProfile.__PropertyOffset_EditProfiles, this));
				}
				return result;
			}
			set
			{
				this.EditProfiles.CopyAssign(value);
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x000BF26C File Offset: 0x000BD46C
		// (set) Token: 0x0600861F RID: 34335 RVA: 0x000BF2A5 File Offset: 0x000BD4A5
		public TArray<FRedirector> ProfileRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRedirector> result;
				if ((result = this._ProfileRedirects) == null)
				{
					result = (this._ProfileRedirects = new TArray<FRedirector>(base.NativePtr + (IntPtr)UCollisionProfile.__PropertyOffset_ProfileRedirects, this));
				}
				return result;
			}
			set
			{
				this.ProfileRedirects.CopyAssign(value);
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06008620 RID: 34336 RVA: 0x000BF2B4 File Offset: 0x000BD4B4
		// (set) Token: 0x06008621 RID: 34337 RVA: 0x000BF2ED File Offset: 0x000BD4ED
		public TArray<FRedirector> CollisionChannelRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRedirector> result;
				if ((result = this._CollisionChannelRedirects) == null)
				{
					result = (this._CollisionChannelRedirects = new TArray<FRedirector>(base.NativePtr + (IntPtr)UCollisionProfile.__PropertyOffset_CollisionChannelRedirects, this));
				}
				return result;
			}
			set
			{
				this.CollisionChannelRedirects.CopyAssign(value);
			}
		}

		// Token: 0x06008622 RID: 34338 RVA: 0x000BF2FB File Offset: 0x000BD4FB
		static UCollisionProfile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CollisionProfile");
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x000BF309 File Offset: 0x000BD509
		protected UCollisionProfile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FC6 RID: 16326
		public new const string __ObjectPath = "/Script/Engine.CollisionProfile";

		// Token: 0x04003FC7 RID: 16327
		private static IntPtr _ClassPtr;

		// Token: 0x04003FC8 RID: 16328
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FC9 RID: 16329
		internal static int __PropertyOffset_Profiles;

		// Token: 0x04003FCA RID: 16330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCollisionResponseTemplate> _Profiles;

		// Token: 0x04003FCB RID: 16331
		internal static int __PropertyOffset_DefaultChannelResponses;

		// Token: 0x04003FCC RID: 16332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomChannelSetup> _DefaultChannelResponses;

		// Token: 0x04003FCD RID: 16333
		internal static int __PropertyOffset_EditProfiles;

		// Token: 0x04003FCE RID: 16334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomProfile> _EditProfiles;

		// Token: 0x04003FCF RID: 16335
		internal static int __PropertyOffset_ProfileRedirects;

		// Token: 0x04003FD0 RID: 16336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRedirector> _ProfileRedirects;

		// Token: 0x04003FD1 RID: 16337
		internal static int __PropertyOffset_CollisionChannelRedirects;

		// Token: 0x04003FD2 RID: 16338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRedirector> _CollisionChannelRedirects;
	}
}
