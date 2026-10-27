using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F82 RID: 8066
	[UnrealObjectPath("/Script/Landscape.LandscapeMeshCollisionComponent")]
	[UnrealStructLayout(2656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2656)]
	public class ULandscapeMeshCollisionComponent : ULandscapeHeightfieldCollisionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E98E RID: 125326 RVA: 0x002D78BA File Offset: 0x002D5ABA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeMeshCollisionComponent._ClassPtr;
		}

		// Token: 0x0601E98F RID: 125327 RVA: 0x002D78C8 File Offset: 0x002D5AC8
		public ULandscapeMeshCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeMeshCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E990 RID: 125328 RVA: 0x002D78F0 File Offset: 0x002D5AF0
		[NullableContext(1)]
		public ULandscapeMeshCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeMeshCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170079BC RID: 31164
		// (get) Token: 0x0601E991 RID: 125329 RVA: 0x002D7923 File Offset: 0x002D5B23
		// (set) Token: 0x0601E992 RID: 125330 RVA: 0x002D7937 File Offset: 0x002D5B37
		public unsafe FGuid MeshGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeMeshCollisionComponent.__PropertyOffset_MeshGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeMeshCollisionComponent.__PropertyOffset_MeshGuid) = value;
			}
		}

		// Token: 0x0601E993 RID: 125331 RVA: 0x002D794C File Offset: 0x002D5B4C
		static ULandscapeMeshCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeMeshCollisionComponent");
		}

		// Token: 0x0601E994 RID: 125332 RVA: 0x002D795A File Offset: 0x002D5B5A
		protected ULandscapeMeshCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401088D RID: 67725
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeMeshCollisionComponent";

		// Token: 0x0401088E RID: 67726
		private static IntPtr _ClassPtr;

		// Token: 0x0401088F RID: 67727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010890 RID: 67728
		internal static int __PropertyOffset_MeshGuid;
	}
}
