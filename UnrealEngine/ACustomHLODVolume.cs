using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200098B RID: 2443
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomHLODVolume")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class ACustomHLODVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008A12 RID: 35346 RVA: 0x000C5BDD File Offset: 0x000C3DDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACustomHLODVolume._ClassPtr;
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x000C5BEC File Offset: 0x000C3DEC
		public ACustomHLODVolume() : this(BuiltinUtils.AllocNativeUObject(ACustomHLODVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x000C5C14 File Offset: 0x000C3E14
		public ACustomHLODVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACustomHLODVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06008A15 RID: 35349 RVA: 0x000C5C48 File Offset: 0x000C3E48
		// (set) Token: 0x06008A16 RID: 35350 RVA: 0x000C5C81 File Offset: 0x000C3E81
		public TArray<AActor> ClusterActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ClusterActors) == null)
				{
					result = (this._ClusterActors = new TArray<AActor>(base.NativePtr + (IntPtr)ACustomHLODVolume.__PropertyOffset_ClusterActors, this));
				}
				return result;
			}
			set
			{
				this.ClusterActors.CopyAssign(value);
			}
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x000C5C8F File Offset: 0x000C3E8F
		static ACustomHLODVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CustomHLODVolume");
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x000C5C9D File Offset: 0x000C3E9D
		protected ACustomHLODVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400418A RID: 16778
		public new const string __ObjectPath = "/Script/Engine.CustomHLODVolume";

		// Token: 0x0400418B RID: 16779
		private static IntPtr _ClassPtr;

		// Token: 0x0400418C RID: 16780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400418D RID: 16781
		internal static int __PropertyOffset_ClusterActors;

		// Token: 0x0400418E RID: 16782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ClusterActors;
	}
}
