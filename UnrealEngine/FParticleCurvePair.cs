using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F42 RID: 3906
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleCurvePair")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FParticleCurvePair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D2A9 RID: 53929 RVA: 0x00134C5D File Offset: 0x00132E5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleCurvePair._ScriptStructPtr != 0) ? FParticleCurvePair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleCurvePair", ref FParticleCurvePair._ScriptStructPtr);
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x00134C81 File Offset: 0x00132E81
		// (set) Token: 0x0600D2AB RID: 53931 RVA: 0x00134C95 File Offset: 0x00132E95
		public unsafe string CurveName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FParticleCurvePair.__PropertyOffset_CurveName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FParticleCurvePair.__PropertyOffset_CurveName)), value);
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600D2AC RID: 53932 RVA: 0x00134CAA File Offset: 0x00132EAA
		// (set) Token: 0x0600D2AD RID: 53933 RVA: 0x00134CBE File Offset: 0x00132EBE
		[Nullable(2)]
		public unsafe UObject CurveObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FParticleCurvePair.__PropertyOffset_CurveObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FParticleCurvePair.__PropertyOffset_CurveObject, value);
			}
		}

		// Token: 0x0600D2AE RID: 53934 RVA: 0x00134CD3 File Offset: 0x00132ED3
		public FParticleCurvePair()
		{
		}

		// Token: 0x0600D2AF RID: 53935 RVA: 0x00134CDB File Offset: 0x00132EDB
		public FParticleCurvePair(string CurveName, UObject CurveObject)
		{
			this.CurveName = CurveName;
			this.CurveObject = CurveObject;
		}

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x00134CF1 File Offset: 0x00132EF1
		protected override IntPtr GetUStructPtr()
		{
			return FParticleCurvePair.StaticStruct();
		}

		// Token: 0x0600D2B1 RID: 53937 RVA: 0x00134CFD File Offset: 0x00132EFD
		[NullableContext(2)]
		public FParticleCurvePair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D2B2 RID: 53938 RVA: 0x00134D07 File Offset: 0x00132F07
		public FParticleCurvePair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D2B3 RID: 53939 RVA: 0x00134D12 File Offset: 0x00132F12
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleCurvePair(Pointer, false, true);
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x00134D1C File Offset: 0x00132F1C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleCurvePair(Pointer, MemoryOwner);
		}

		// Token: 0x04007103 RID: 28931
		public const string __ObjectPath = "/Script/Engine.ParticleCurvePair";

		// Token: 0x04007104 RID: 28932
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007105 RID: 28933
		internal static int __PropertyOffset_CurveName;

		// Token: 0x04007106 RID: 28934
		internal static int __PropertyOffset_CurveObject;
	}
}
