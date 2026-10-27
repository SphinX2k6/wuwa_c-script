using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200089D RID: 2205
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedStringCustomAttribute")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FBakedStringCustomAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078AC RID: 30892 RVA: 0x000ACCC6 File Offset: 0x000AAEC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedStringCustomAttribute._ScriptStructPtr != 0) ? FBakedStringCustomAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedStringCustomAttribute", ref FBakedStringCustomAttribute._ScriptStructPtr);
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x000ACCEA File Offset: 0x000AAEEA
		// (set) Token: 0x060078AE RID: 30894 RVA: 0x000ACCFE File Offset: 0x000AAEFE
		public unsafe FName AttributeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStringCustomAttribute.__PropertyOffset_AttributeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStringCustomAttribute.__PropertyOffset_AttributeName) = value;
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x060078AF RID: 30895 RVA: 0x000ACD14 File Offset: 0x000AAF14
		// (set) Token: 0x060078B0 RID: 30896 RVA: 0x000ACD57 File Offset: 0x000AAF57
		public FStringCurve StringCurve
		{
			get
			{
				base.FastCheckIsValid();
				FStringCurve result;
				if ((result = this._StringCurve) == null)
				{
					result = (this._StringCurve = new FStringCurve(base.NativePtr + (IntPtr)FBakedStringCustomAttribute.__PropertyOffset_StringCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStringCurve.StaticStruct(), base.NativePtr + (IntPtr)FBakedStringCustomAttribute.__PropertyOffset_StringCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x000ACD78 File Offset: 0x000AAF78
		public FBakedStringCustomAttribute()
		{
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x000ACD80 File Offset: 0x000AAF80
		public FBakedStringCustomAttribute(FName AttributeName, FStringCurve StringCurve)
		{
			this.AttributeName = AttributeName;
			this.StringCurve = StringCurve;
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x000ACD96 File Offset: 0x000AAF96
		protected override IntPtr GetUStructPtr()
		{
			return FBakedStringCustomAttribute.StaticStruct();
		}

		// Token: 0x060078B4 RID: 30900 RVA: 0x000ACDA2 File Offset: 0x000AAFA2
		[NullableContext(2)]
		public FBakedStringCustomAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x000ACDAC File Offset: 0x000AAFAC
		public FBakedStringCustomAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x000ACDB7 File Offset: 0x000AAFB7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedStringCustomAttribute(Pointer, false, true);
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x000ACDC1 File Offset: 0x000AAFC1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedStringCustomAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x040039F7 RID: 14839
		public const string __ObjectPath = "/Script/Engine.BakedStringCustomAttribute";

		// Token: 0x040039F8 RID: 14840
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039F9 RID: 14841
		internal static int __PropertyOffset_AttributeName;

		// Token: 0x040039FA RID: 14842
		internal static int __PropertyOffset_StringCurve;

		// Token: 0x040039FB RID: 14843
		[Nullable(2)]
		private FStringCurve _StringCurve;
	}
}
