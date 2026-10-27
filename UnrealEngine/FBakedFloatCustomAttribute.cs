using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200089A RID: 2202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedFloatCustomAttribute")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FBakedFloatCustomAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600787E RID: 30846 RVA: 0x000AC8D6 File Offset: 0x000AAAD6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedFloatCustomAttribute._ScriptStructPtr != 0) ? FBakedFloatCustomAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedFloatCustomAttribute", ref FBakedFloatCustomAttribute._ScriptStructPtr);
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x000AC8FA File Offset: 0x000AAAFA
		// (set) Token: 0x06007880 RID: 30848 RVA: 0x000AC90E File Offset: 0x000AAB0E
		public unsafe FName AttributeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedFloatCustomAttribute.__PropertyOffset_AttributeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedFloatCustomAttribute.__PropertyOffset_AttributeName) = value;
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06007881 RID: 30849 RVA: 0x000AC924 File Offset: 0x000AAB24
		// (set) Token: 0x06007882 RID: 30850 RVA: 0x000AC967 File Offset: 0x000AAB67
		public FSimpleCurve FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleCurve result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FSimpleCurve(base.NativePtr + (IntPtr)FBakedFloatCustomAttribute.__PropertyOffset_FloatCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSimpleCurve.StaticStruct(), base.NativePtr + (IntPtr)FBakedFloatCustomAttribute.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x000AC988 File Offset: 0x000AAB88
		public FBakedFloatCustomAttribute()
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x000AC990 File Offset: 0x000AAB90
		public FBakedFloatCustomAttribute(FName AttributeName, FSimpleCurve FloatCurve)
		{
			this.AttributeName = AttributeName;
			this.FloatCurve = FloatCurve;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x000AC9A6 File Offset: 0x000AABA6
		protected override IntPtr GetUStructPtr()
		{
			return FBakedFloatCustomAttribute.StaticStruct();
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x000AC9B2 File Offset: 0x000AABB2
		[NullableContext(2)]
		public FBakedFloatCustomAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x000AC9BC File Offset: 0x000AABBC
		public FBakedFloatCustomAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x000AC9C7 File Offset: 0x000AABC7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedFloatCustomAttribute(Pointer, false, true);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x000AC9D1 File Offset: 0x000AABD1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedFloatCustomAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x040039E2 RID: 14818
		public const string __ObjectPath = "/Script/Engine.BakedFloatCustomAttribute";

		// Token: 0x040039E3 RID: 14819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039E4 RID: 14820
		internal static int __PropertyOffset_AttributeName;

		// Token: 0x040039E5 RID: 14821
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x040039E6 RID: 14822
		[Nullable(2)]
		private FSimpleCurve _FloatCurve;
	}
}
