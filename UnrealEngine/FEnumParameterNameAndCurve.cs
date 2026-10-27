using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004F2 RID: 1266
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.EnumParameterNameAndCurve")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FEnumParameterNameAndCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600430F RID: 17167 RVA: 0x0006410D File Offset: 0x0006230D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnumParameterNameAndCurve._ScriptStructPtr != 0) ? FEnumParameterNameAndCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.EnumParameterNameAndCurve", ref FEnumParameterNameAndCurve._ScriptStructPtr);
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x00064131 File Offset: 0x00062331
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x00064145 File Offset: 0x00062345
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnumParameterNameAndCurve.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnumParameterNameAndCurve.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0006415C File Offset: 0x0006235C
		// (set) Token: 0x06004313 RID: 17171 RVA: 0x0006419F File Offset: 0x0006239F
		public FMovieSceneByteChannel ParameterCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneByteChannel result;
				if ((result = this._ParameterCurve) == null)
				{
					result = (this._ParameterCurve = new FMovieSceneByteChannel(base.NativePtr + (IntPtr)FEnumParameterNameAndCurve.__PropertyOffset_ParameterCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneByteChannel.StaticStruct(), base.NativePtr + (IntPtr)FEnumParameterNameAndCurve.__PropertyOffset_ParameterCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000641C0 File Offset: 0x000623C0
		public FEnumParameterNameAndCurve()
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000641C8 File Offset: 0x000623C8
		public FEnumParameterNameAndCurve(FName ParameterName, FMovieSceneByteChannel ParameterCurve)
		{
			this.ParameterName = ParameterName;
			this.ParameterCurve = ParameterCurve;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000641DE File Offset: 0x000623DE
		protected override IntPtr GetUStructPtr()
		{
			return FEnumParameterNameAndCurve.StaticStruct();
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000641EA File Offset: 0x000623EA
		[NullableContext(2)]
		public FEnumParameterNameAndCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x000641F4 File Offset: 0x000623F4
		public FEnumParameterNameAndCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x000641FF File Offset: 0x000623FF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnumParameterNameAndCurve(Pointer, false, true);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00064209 File Offset: 0x00062409
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnumParameterNameAndCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400204D RID: 8269
		public const string __ObjectPath = "/Script/ControlRig.EnumParameterNameAndCurve";

		// Token: 0x0400204E RID: 8270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400204F RID: 8271
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04002050 RID: 8272
		internal static int __PropertyOffset_ParameterCurve;

		// Token: 0x04002051 RID: 8273
		[Nullable(2)]
		private FMovieSceneByteChannel _ParameterCurve;
	}
}
