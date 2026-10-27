using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200230D RID: 8973
	[UnrealObjectPath("/Script/MovieSceneCapture.LevelCapture")]
	[UnrealStructLayout(608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class ULevelCapture : UMovieSceneCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F99 RID: 139161 RVA: 0x00323D6E File Offset: 0x00321F6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelCapture._ClassPtr;
		}

		// Token: 0x06021F9A RID: 139162 RVA: 0x00323D7C File Offset: 0x00321F7C
		public ULevelCapture() : this(BuiltinUtils.AllocNativeUObject(ULevelCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F9B RID: 139163 RVA: 0x00323DA4 File Offset: 0x00321FA4
		[NullableContext(1)]
		public ULevelCapture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelCapture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700834C RID: 33612
		// (get) Token: 0x06021F9C RID: 139164 RVA: 0x00323DD7 File Offset: 0x00321FD7
		// (set) Token: 0x06021F9D RID: 139165 RVA: 0x00323DE7 File Offset: 0x00321FE7
		public unsafe bool bAutoStartCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelCapture.__PropertyOffset_bAutoStartCapture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelCapture.__PropertyOffset_bAutoStartCapture) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700834D RID: 33613
		// (get) Token: 0x06021F9E RID: 139166 RVA: 0x00323DF8 File Offset: 0x00321FF8
		// (set) Token: 0x06021F9F RID: 139167 RVA: 0x00323E0C File Offset: 0x0032200C
		public unsafe FGuid PrerequisiteActorId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelCapture.__PropertyOffset_PrerequisiteActorId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelCapture.__PropertyOffset_PrerequisiteActorId) = value;
			}
		}

		// Token: 0x06021FA0 RID: 139168 RVA: 0x00323E21 File Offset: 0x00322021
		static ULevelCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneCapture.LevelCapture");
		}

		// Token: 0x06021FA1 RID: 139169 RVA: 0x00323E2F File Offset: 0x0032202F
		protected ULevelCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121FD RID: 74237
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneCapture.LevelCapture";

		// Token: 0x040121FE RID: 74238
		private static IntPtr _ClassPtr;

		// Token: 0x040121FF RID: 74239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012200 RID: 74240
		internal static int __PropertyOffset_bAutoStartCapture;

		// Token: 0x04012201 RID: 74241
		internal static int __PropertyOffset_PrerequisiteActorId;
	}
}
