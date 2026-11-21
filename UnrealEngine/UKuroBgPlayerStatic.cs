using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000316 RID: 790
	[UnrealObjectPath("/Script/KuroAudio.KuroBgPlayerStatic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBgPlayerStatic : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060053BA RID: 21434 RVA: 0x0007507E File Offset: 0x0007327E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBgPlayerStatic._ClassPtr;
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0007508C File Offset: 0x0007328C
		public UKuroBgPlayerStatic() : this(BuiltinUtils.AllocNativeUObject(UKuroBgPlayerStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x000750B4 File Offset: 0x000732B4
		[NullableContext(1)]
		public UKuroBgPlayerStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBgPlayerStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060053BD RID: 21437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Stop();

		// Token: 0x060053BE RID: 21438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Play();

		// Token: 0x060053BF RID: 21439 RVA: 0x000750E7 File Offset: 0x000732E7
		static UKuroBgPlayerStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroBgPlayerStatic");
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x000750F5 File Offset: 0x000732F5
		protected UKuroBgPlayerStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002232 RID: 8754
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroBgPlayerStatic";

		// Token: 0x04002233 RID: 8755
		private static IntPtr _ClassPtr;

		// Token: 0x04002234 RID: 8756
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
