using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200169E RID: 5790
	[UnrealObjectPath("/Script/KuroAudio.KuroBgPlayerStatic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBgPlayerStatic : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014FEF RID: 85999 RVA: 0x001EDB6E File Offset: 0x001EBD6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBgPlayerStatic._ClassPtr;
		}

		// Token: 0x06014FF0 RID: 86000 RVA: 0x001EDB7C File Offset: 0x001EBD7C
		public UKuroBgPlayerStatic() : this(BuiltinUtils.AllocNativeUObject(UKuroBgPlayerStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014FF1 RID: 86001 RVA: 0x001EDBA4 File Offset: 0x001EBDA4
		[NullableContext(1)]
		public UKuroBgPlayerStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBgPlayerStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014FF2 RID: 86002
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Stop();

		// Token: 0x06014FF3 RID: 86003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Play();

		// Token: 0x06014FF4 RID: 86004 RVA: 0x001EDBD7 File Offset: 0x001EBDD7
		static UKuroBgPlayerStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroBgPlayerStatic");
		}

		// Token: 0x06014FF5 RID: 86005 RVA: 0x001EDBE5 File Offset: 0x001EBDE5
		protected UKuroBgPlayerStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6ED RID: 46829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroBgPlayerStatic";

		// Token: 0x0400B6EE RID: 46830
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6EF RID: 46831
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
