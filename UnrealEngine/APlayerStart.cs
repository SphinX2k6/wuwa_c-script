using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000263 RID: 611
	[UnrealObjectPath("/Script/Engine.PlayerStart")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class APlayerStart : ANavigationObjectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003664 RID: 13924 RVA: 0x0004CBA4 File Offset: 0x0004ADA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerStart._ClassPtr;
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		public APlayerStart() : this(BuiltinUtils.AllocNativeUObject(APlayerStart.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		[NullableContext(1)]
		public APlayerStart(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerStart.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x0004CC0B File Offset: 0x0004AE0B
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x0004CC1F File Offset: 0x0004AE1F
		public unsafe FName PlayerStartTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerStart.__PropertyOffset_PlayerStartTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerStart.__PropertyOffset_PlayerStartTag) = value;
			}
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0004CC34 File Offset: 0x0004AE34
		static APlayerStart()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerStart");
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0004CC42 File Offset: 0x0004AE42
		protected APlayerStart(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040012B7 RID: 4791
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerStart";

		// Token: 0x040012B8 RID: 4792
		private static IntPtr _ClassPtr;

		// Token: 0x040012B9 RID: 4793
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040012BA RID: 4794
		internal static int __PropertyOffset_PlayerStartTag;
	}
}
