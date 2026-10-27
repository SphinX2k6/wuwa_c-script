using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DD RID: 6109
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroJacobiClothSetMapping")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroJacobiClothSetMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060168A4 RID: 92324 RVA: 0x0020E8CC File Offset: 0x0020CACC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroJacobiClothSetMapping._ScriptStructPtr != 0) ? FKuroJacobiClothSetMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroJacobiClothSetMapping", ref FKuroJacobiClothSetMapping._ScriptStructPtr);
		}

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x060168A5 RID: 92325 RVA: 0x0020E8F0 File Offset: 0x0020CAF0
		// (set) Token: 0x060168A6 RID: 92326 RVA: 0x0020E904 File Offset: 0x0020CB04
		public unsafe UStaticMesh SourceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroJacobiClothSetMapping.__PropertyOffset_SourceMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroJacobiClothSetMapping.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x060168A7 RID: 92327 RVA: 0x0020E919 File Offset: 0x0020CB19
		// (set) Token: 0x060168A8 RID: 92328 RVA: 0x0020E92D File Offset: 0x0020CB2D
		public unsafe UKuroClothDataAsset Profile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroClothDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroJacobiClothSetMapping.__PropertyOffset_Profile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroJacobiClothSetMapping.__PropertyOffset_Profile, value);
			}
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x060168A9 RID: 92329 RVA: 0x0020E942 File Offset: 0x0020CB42
		// (set) Token: 0x060168AA RID: 92330 RVA: 0x0020E952 File Offset: 0x0020CB52
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroJacobiClothSetMapping.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroJacobiClothSetMapping.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x060168AB RID: 92331 RVA: 0x0020E963 File Offset: 0x0020CB63
		public FKuroJacobiClothSetMapping()
		{
		}

		// Token: 0x060168AC RID: 92332 RVA: 0x0020E96B File Offset: 0x0020CB6B
		[NullableContext(1)]
		public FKuroJacobiClothSetMapping(UStaticMesh SourceMesh, UKuroClothDataAsset Profile, bool bEnabled)
		{
			this.SourceMesh = SourceMesh;
			this.Profile = Profile;
			this.bEnabled = bEnabled;
		}

		// Token: 0x060168AD RID: 92333 RVA: 0x0020E988 File Offset: 0x0020CB88
		protected override IntPtr GetUStructPtr()
		{
			return FKuroJacobiClothSetMapping.StaticStruct();
		}

		// Token: 0x060168AE RID: 92334 RVA: 0x0020E994 File Offset: 0x0020CB94
		public FKuroJacobiClothSetMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060168AF RID: 92335 RVA: 0x0020E99E File Offset: 0x0020CB9E
		public FKuroJacobiClothSetMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060168B0 RID: 92336 RVA: 0x0020E9A9 File Offset: 0x0020CBA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroJacobiClothSetMapping(Pointer, false, true);
		}

		// Token: 0x060168B1 RID: 92337 RVA: 0x0020E9B3 File Offset: 0x0020CBB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroJacobiClothSetMapping(Pointer, MemoryOwner);
		}

		// Token: 0x0400C3E4 RID: 50148
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroJacobiClothSetMapping";

		// Token: 0x0400C3E5 RID: 50149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C3E6 RID: 50150
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400C3E7 RID: 50151
		internal static int __PropertyOffset_Profile;

		// Token: 0x0400C3E8 RID: 50152
		internal static int __PropertyOffset_bEnabled;
	}
}
