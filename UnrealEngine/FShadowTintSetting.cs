using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C27 RID: 7207
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ShadowTintSetting")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FShadowTintSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BD7D RID: 114045 RVA: 0x0028FAAF File Offset: 0x0028DCAF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FShadowTintSetting._ScriptStructPtr != 0) ? FShadowTintSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.ShadowTintSetting", ref FShadowTintSetting._ScriptStructPtr);
		}

		// Token: 0x1700705C RID: 28764
		// (get) Token: 0x0601BD7E RID: 114046 RVA: 0x0028FAD3 File Offset: 0x0028DCD3
		// (set) Token: 0x0601BD7F RID: 114047 RVA: 0x0028FAEC File Offset: 0x0028DCEC
		public unsafe bool bOverride_ShadowTintOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintOffset) & FShadowTintSetting.__PropertyMask_bOverride_ShadowTintOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintOffset) = ((*(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintOffset) & ~FShadowTintSetting.__PropertyMask_bOverride_ShadowTintOffset) | (value ? FShadowTintSetting.__PropertyMask_bOverride_ShadowTintOffset : 0));
			}
		}

		// Token: 0x1700705D RID: 28765
		// (get) Token: 0x0601BD80 RID: 114048 RVA: 0x0028FB1C File Offset: 0x0028DD1C
		// (set) Token: 0x0601BD81 RID: 114049 RVA: 0x0028FB2C File Offset: 0x0028DD2C
		public unsafe float ShadowTintOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_ShadowTintOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_ShadowTintOffset) = value;
			}
		}

		// Token: 0x1700705E RID: 28766
		// (get) Token: 0x0601BD82 RID: 114050 RVA: 0x0028FB3D File Offset: 0x0028DD3D
		// (set) Token: 0x0601BD83 RID: 114051 RVA: 0x0028FB56 File Offset: 0x0028DD56
		public unsafe bool bOverride_ShadowTintLutRamp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintLutRamp) & FShadowTintSetting.__PropertyMask_bOverride_ShadowTintLutRamp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintLutRamp) = ((*(base.NativePtr + (IntPtr)FShadowTintSetting.__PropertyOffset_bOverride_ShadowTintLutRamp) & ~FShadowTintSetting.__PropertyMask_bOverride_ShadowTintLutRamp) | (value ? FShadowTintSetting.__PropertyMask_bOverride_ShadowTintLutRamp : 0));
			}
		}

		// Token: 0x1700705F RID: 28767
		// (get) Token: 0x0601BD84 RID: 114052 RVA: 0x0028FB86 File Offset: 0x0028DD86
		// (set) Token: 0x0601BD85 RID: 114053 RVA: 0x0028FB9A File Offset: 0x0028DD9A
		[Nullable(2)]
		public unsafe UTexture2D ShadowTintLutRamp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FShadowTintSetting.__PropertyOffset_ShadowTintLutRamp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FShadowTintSetting.__PropertyOffset_ShadowTintLutRamp, value);
			}
		}

		// Token: 0x0601BD86 RID: 114054 RVA: 0x0028FBAF File Offset: 0x0028DDAF
		public FShadowTintSetting()
		{
		}

		// Token: 0x0601BD87 RID: 114055 RVA: 0x0028FBB7 File Offset: 0x0028DDB7
		[NullableContext(1)]
		public FShadowTintSetting(bool bOverride_ShadowTintOffset, float ShadowTintOffset, bool bOverride_ShadowTintLutRamp, UTexture2D ShadowTintLutRamp)
		{
			this.bOverride_ShadowTintOffset = bOverride_ShadowTintOffset;
			this.ShadowTintOffset = ShadowTintOffset;
			this.bOverride_ShadowTintLutRamp = bOverride_ShadowTintLutRamp;
			this.ShadowTintLutRamp = ShadowTintLutRamp;
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x0028FBDC File Offset: 0x0028DDDC
		protected override IntPtr GetUStructPtr()
		{
			return FShadowTintSetting.StaticStruct();
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x0028FBE8 File Offset: 0x0028DDE8
		[NullableContext(2)]
		public FShadowTintSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD8A RID: 114058 RVA: 0x0028FBF2 File Offset: 0x0028DDF2
		public FShadowTintSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD8B RID: 114059 RVA: 0x0028FBFD File Offset: 0x0028DDFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FShadowTintSetting(Pointer, false, true);
		}

		// Token: 0x0601BD8C RID: 114060 RVA: 0x0028FC07 File Offset: 0x0028DE07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FShadowTintSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF62 RID: 61282
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.ShadowTintSetting";

		// Token: 0x0400EF63 RID: 61283
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF64 RID: 61284
		internal static int __PropertyOffset_bOverride_ShadowTintOffset;

		// Token: 0x0400EF65 RID: 61285
		internal static byte __PropertyMask_bOverride_ShadowTintOffset;

		// Token: 0x0400EF66 RID: 61286
		internal static int __PropertyOffset_ShadowTintOffset;

		// Token: 0x0400EF67 RID: 61287
		internal static int __PropertyOffset_bOverride_ShadowTintLutRamp;

		// Token: 0x0400EF68 RID: 61288
		internal static byte __PropertyMask_bOverride_ShadowTintLutRamp;

		// Token: 0x0400EF69 RID: 61289
		internal static int __PropertyOffset_ShadowTintLutRamp;
	}
}
