using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200007A RID: 122
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Subclass)]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.Subclass, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public readonly struct TSubclassOf<[Nullable(0)] T> : IEquatable<TSubclassOf<T>>, IEqualityOperators<TSubclassOf<T>, TSubclassOf<T>, bool> where T : IUnrealUObject
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x00013243 File Offset: 0x00011443
		public TSubclassOf(IntPtr From)
		{
			this._NativePtr = From;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0001324C File Offset: 0x0001144C
		public TSubclassOf(UClassStackOnlyPtr From)
		{
			this._NativePtr = From.NativePtr;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0001325B File Offset: 0x0001145B
		public TSubclassOf(UClass From)
		{
			this._NativePtr = ((From != null) ? From._NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00013273 File Offset: 0x00011473
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public TSubclassOf<TResult> As<TResult>() where TResult : IUnrealUObject
		{
			return new TSubclassOf<TResult>(this._NativePtr);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00013280 File Offset: 0x00011480
		public UClassStackOnlyPtr Get()
		{
			return UClass.IsChildOf(this._NativePtr, IUnrealUObject.StaticClass()) ? this._NativePtr : IntPtr.Zero;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000132B4 File Offset: 0x000114B4
		public bool IsValid()
		{
			return this.Get().IsValid();
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000132CF File Offset: 0x000114CF
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000132E0 File Offset: 0x000114E0
		public override bool Equals(object Obj)
		{
			if (Obj is TSubclassOf<T>)
			{
				TSubclassOf<T> b = (TSubclassOf<T>)Obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001330A File Offset: 0x0001150A
		public override int GetHashCode()
		{
			return this._NativePtr.GetHashCode();
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00013317 File Offset: 0x00011517
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> A, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> B)
		{
			return A._NativePtr == B._NativePtr;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00013327 File Offset: 0x00011527
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> A, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> B)
		{
			return !(A == B);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00013333 File Offset: 0x00011533
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(IntPtr ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0001333B File Offset: 0x0001153B
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(UClassStackOnlyPtr ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00013343 File Offset: 0x00011543
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(UClass ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001334B File Offset: 0x0001154B
		public static implicit operator UClassStackOnlyPtr([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> Class)
		{
			return Class.Get();
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00013354 File Offset: 0x00011554
		public bool IsChildOf(UClassStackOnlyPtr B)
		{
			return UClass.IsChildOf(this, B);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00013367 File Offset: 0x00011567
		public bool IsA(UClassStackOnlyPtr B)
		{
			return UClass.IsA(this, B);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0001337A File Offset: 0x0001157A
		public FName GetFName()
		{
			return UClass.GetFName(this);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001338C File Offset: 0x0001158C
		[NullableContext(1)]
		public string GetName()
		{
			return UClass.GetName(this);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0001339E File Offset: 0x0001159E
		[NullableContext(1)]
		public string GetPathName()
		{
			return UClass.GetPathName(this);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000133B0 File Offset: 0x000115B0
		public UClass ToUClass()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(this._NativePtr);
		}

		// Token: 0x040001B4 RID: 436
		public readonly IntPtr _NativePtr;
	}
}
