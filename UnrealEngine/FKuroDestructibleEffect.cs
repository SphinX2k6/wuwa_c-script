using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AE4 RID: 6884
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroDestructibleEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019AC6 RID: 105158 RVA: 0x0025F019 File Offset: 0x0025D219
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroDestructibleEffect._ScriptStructPtr != 0) ? FKuroDestructibleEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect", ref FKuroDestructibleEffect._ScriptStructPtr);
		}

		// Token: 0x17006697 RID: 26263
		// (get) Token: 0x06019AC7 RID: 105159 RVA: 0x0025F03D File Offset: 0x0025D23D
		// (set) Token: 0x06019AC8 RID: 105160 RVA: 0x0025F051 File Offset: 0x0025D251
		public unsafe FName EffectModelPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_EffectModelPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_EffectModelPath) = value;
			}
		}

		// Token: 0x17006698 RID: 26264
		// (get) Token: 0x06019AC9 RID: 105161 RVA: 0x0025F066 File Offset: 0x0025D266
		// (set) Token: 0x06019ACA RID: 105162 RVA: 0x0025F07A File Offset: 0x0025D27A
		public unsafe FTransform Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17006699 RID: 26265
		// (get) Token: 0x06019ACB RID: 105163 RVA: 0x0025F08F File Offset: 0x0025D28F
		// (set) Token: 0x06019ACC RID: 105164 RVA: 0x0025F0A3 File Offset: 0x0025D2A3
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x1700669A RID: 26266
		// (get) Token: 0x06019ACD RID: 105165 RVA: 0x0025F0B8 File Offset: 0x0025D2B8
		// (set) Token: 0x06019ACE RID: 105166 RVA: 0x0025F0C8 File Offset: 0x0025D2C8
		public unsafe bool AttachLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700669B RID: 26267
		// (get) Token: 0x06019ACF RID: 105167 RVA: 0x0025F0D9 File Offset: 0x0025D2D9
		// (set) Token: 0x06019AD0 RID: 105168 RVA: 0x0025F0E9 File Offset: 0x0025D2E9
		public unsafe bool AttachRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700669C RID: 26268
		// (get) Token: 0x06019AD1 RID: 105169 RVA: 0x0025F0FA File Offset: 0x0025D2FA
		// (set) Token: 0x06019AD2 RID: 105170 RVA: 0x0025F10A File Offset: 0x0025D30A
		public unsafe bool AttachScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700669D RID: 26269
		// (get) Token: 0x06019AD3 RID: 105171 RVA: 0x0025F11B File Offset: 0x0025D31B
		// (set) Token: 0x06019AD4 RID: 105172 RVA: 0x0025F12B File Offset: 0x0025D32B
		public unsafe bool DetachOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_DetachOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_DetachOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x06019AD5 RID: 105173 RVA: 0x0025F13C File Offset: 0x0025D33C
		public FKuroDestructibleEffect()
		{
		}

		// Token: 0x06019AD6 RID: 105174 RVA: 0x0025F144 File Offset: 0x0025D344
		public FKuroDestructibleEffect(FName EffectModelPath, FTransform Offset, FName Socket, bool AttachLocation, bool AttachRotation, bool AttachScale, bool DetachOnEnd)
		{
			this.EffectModelPath = EffectModelPath;
			this.Offset = Offset;
			this.Socket = Socket;
			this.AttachLocation = AttachLocation;
			this.AttachRotation = AttachRotation;
			this.AttachScale = AttachScale;
			this.DetachOnEnd = DetachOnEnd;
		}

		// Token: 0x06019AD7 RID: 105175 RVA: 0x0025F181 File Offset: 0x0025D381
		protected override IntPtr GetUStructPtr()
		{
			return FKuroDestructibleEffect.StaticStruct();
		}

		// Token: 0x06019AD8 RID: 105176 RVA: 0x0025F18D File Offset: 0x0025D38D
		[NullableContext(2)]
		public FKuroDestructibleEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019AD9 RID: 105177 RVA: 0x0025F197 File Offset: 0x0025D397
		public FKuroDestructibleEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019ADA RID: 105178 RVA: 0x0025F1A2 File Offset: 0x0025D3A2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroDestructibleEffect(Pointer, false, true);
		}

		// Token: 0x06019ADB RID: 105179 RVA: 0x0025F1AC File Offset: 0x0025D3AC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroDestructibleEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400DF7B RID: 57211
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect";

		// Token: 0x0400DF7C RID: 57212
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DF7D RID: 57213
		internal static int __PropertyOffset_EffectModelPath;

		// Token: 0x0400DF7E RID: 57214
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400DF7F RID: 57215
		internal static int __PropertyOffset_Socket;

		// Token: 0x0400DF80 RID: 57216
		internal static int __PropertyOffset_AttachLocation;

		// Token: 0x0400DF81 RID: 57217
		internal static int __PropertyOffset_AttachRotation;

		// Token: 0x0400DF82 RID: 57218
		internal static int __PropertyOffset_AttachScale;

		// Token: 0x0400DF83 RID: 57219
		internal static int __PropertyOffset_DetachOnEnd;
	}
}
